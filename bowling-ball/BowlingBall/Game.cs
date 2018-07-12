using Contracts;
using FrameManagerImplementation;
using ScoringManagerImplementation;
using System.Collections.Generic;
using System.Linq;

namespace BowlingBall
{
    public class Game
    {
        List<Frame> _frames = new List<Frame>();

        public void Roll(int pins)
        {
            var frame = new FrameManager().CreateFrame(_frames, pins);

            if (_frames.Count > 0 && frame.FrameIndex == _frames.Last().FrameIndex)
                _frames[frame.FrameIndex] = frame;
            else
                _frames.Add(frame);
        }

        public int GetScore()
        {
            return new ScoringManager().GetScore(_frames);
        }
    }
}
