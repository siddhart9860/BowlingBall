using Contracts;
using System.Collections.Generic;

namespace FrameManagerImplementation
{
    public class FrameManager
    {
        private Frame _currentFrame;

        public Frame CreateFrame(List<Frame> frames, int pins)
        {
            if (frames.Count == 0)
                _currentFrame = new Frame(frames.Count);
            else
                _currentFrame = frames[frames.Count - 1];


            if (_currentFrame.IsCompleted)
                _currentFrame = new Frame(frames.Count);

            if ((pins == 10 && _currentFrame.Rolls.Count == 0) || _currentFrame.Rolls.Count == 1)
            {
                _currentFrame.Rolls.Add(pins);
                _currentFrame.IsCompleted = true;
            }
            else
            {
                _currentFrame.Rolls.Add(pins);
                _currentFrame.IsCompleted = false;
            }

            return _currentFrame;
        }
    }
}
