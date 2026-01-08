using Creighton_v1.Domain.Enums;
using Creighton_v1.Domain.ValueObjects;
using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public class DailyEntry : Entity<DailyEntryId>
{
    private DateOnly _date;
    private StampTypes? _stampType;
    private Observation? _observation;
    private DailyEntryState _state;
    private bool _intercourse;
    private bool _isFertile;

    // EF
    private DailyEntry() { }

    public DailyEntry(
        DateOnly date,
        Observation? observation,
        bool intercourse,
        IEnumerable<DailyEntry> cycleDailyEntries
    )
    {
        _date = date;
        _observation = observation;
        _intercourse = intercourse;

        EvaluateDailyEntry(
            cycleDailyEntries.Where(de => de._date < _date).OrderBy(de => de._date).ToList()
        );
    }

    private void EvaluateDailyEntry(List<DailyEntry> cyclePreviousDailyEntries)
    {
        // First evaluate entry state
        EvaluateDailyEntryState(cyclePreviousDailyEntries);
        // Instruction H. When there is doubt in observation, consider as fertille + 3 days
        if (_observation is null)
        {
            _isFertile = true;
            _stampType = StampTypes.WhiteBaby;
            return;
        }
        // 1. Red if any bleeding or brown
        if (_observation.BleedingIntensity is not null)
        {
            // TODO: Consider adding evaluation in case of certain instruction, then menses can be evaluated as non fertile
            _isFertile = true;
            _stampType = StampTypes.Red;
            return;
        }

        // 2. Mucus present (White Stamp)
        // Any mucus type other than Dry is typically considered fertile in the build-up phase
        if (_observation.MucusType != MucusTypes.Dry)
        {
            _isFertile = true;
            _stampType = StampTypes.WhiteBaby;
            return;
        }

        // 3. Dry (Green Stamp)
        // If we are here, it is Dry and no Blood.
        _isFertile = false;
        _stampType = StampTypes.Green;
    }

    private void EvaluateDailyEntryState(List<DailyEntry> cyclePreviousDailyEntries)
    {
        if (
            (
                cyclePreviousDailyEntries.LastOrDefault()?._observation?.MucusType
                & Consts.Consts.PeakMucus
            ) != 0
            && (_observation?.MucusType & Consts.Consts.PeakMucus) == 0
        )
            _state = DailyEntryState.Peak; // This is the peak day
        else
            _state = DailyEntryState.BeforePeak;

        if (cyclePreviousDailyEntries.Any(de => de._state == DailyEntryState.Peak))
            _state = DailyEntryState.AfterPeak;

        if (_observation is null)
        {
            _state = DailyEntryState.BeforePeak;
        }
    }
}
