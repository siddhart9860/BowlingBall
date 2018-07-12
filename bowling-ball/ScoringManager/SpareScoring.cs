using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ScoringManagerImplementation
{
    public class SpareScoring
    {
        public int GetBonusScore(Frame currentFrame, List<Frame> frames)
        {
            return frames[currentFrame.FrameIndex + 1].Rolls.First();
        }
    }
}
