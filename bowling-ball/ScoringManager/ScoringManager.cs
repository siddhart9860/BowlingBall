using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ScoringManagerImplementation
{
    public class ScoringManager
    {
        public int GetScore(List<Frame> frames)
        {
            var score = frames.Where(x => x.FrameIndex < 10).Select(x => x.Score).Sum();

            foreach (var frame in frames.Where(x => x.FrameIndex < 10))
            {
                if (frame.Strategy == FrameType.Strike)
                {
                    score += new StrikeScoring().GetBonusScore(frame, frames);
                }
                else if (frame.Strategy == FrameType.Spare)
                {
                    score += new SpareScoring().GetBonusScore(frame, frames);
                }
            }

            return score;
        }
    }
}
