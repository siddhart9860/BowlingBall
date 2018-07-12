using System.Collections.Generic;
using System.Linq;

namespace Contracts
{
    public class Frame
    {
        public Frame(int frameIndex)
        {
            FrameIndex = frameIndex;
        }

        public int FrameIndex { get; set; }

        public List<int> Rolls = new List<int>();

        public FrameType Strategy
        {
            get
            {
                if (Rolls.Count == 1 && Rolls.Sum() == 10)
                    return FrameType.Strike;

                if (Rolls.Count == 2 && Rolls.Sum() == 10)
                    return FrameType.Spare;

                return FrameType.Normal;
            }
        }

        public bool IsCompleted { get; set; }

        public bool IsLast => FrameIndex == 9;

        //public Frame NextFrame { get; set; }

        public int Score => Rolls.Sum();
    }
}
