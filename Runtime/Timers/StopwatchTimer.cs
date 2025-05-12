using UnityEngine;

namespace ImprovedTimers {
    /// <summary>
    /// Timer that counts up from zero to infinity.  Great for measuring durations.
    /// </summary>
    public class StopwatchTimer : Timer {
        public StopwatchTimer(bool useUnscaledTime = false) : base(0, useUnscaledTime) { }

        public override void Tick() {
            if (IsRunning) {
                CurrentTime += GetDeltaTime();
            }
        }

        public override bool IsFinished => false;
    }
}