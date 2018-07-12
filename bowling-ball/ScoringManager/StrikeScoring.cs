using Contracts;
using System.Collections.Generic;

namespace ScoringManagerImplementation
{
    public class StrikeScoring
    {
        public int GetBonusScore(Frame currentFrame, List<Frame> frames)
        {
            var firstBonusFrame = frames[currentFrame.FrameIndex + 1];

            var score = firstBonusFrame.Score;

            if (firstBonusFrame.Strategy == FrameType.Strike)
            {
                score += frames[currentFrame.FrameIndex + 2].Score;
            }

            return score;
        }
    }
}
