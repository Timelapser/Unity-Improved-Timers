using UnityEngine;

namespace ImprovedTimers {
    /// <summary>
    /// Timer that counts down from a specific value to zero.
    /// </summary>
    public class CountdownTimer : Timer {
        public CountdownTimer(float value, bool useUnscaledTime = false) : base(value, useUnscaledTime) { }

        public override void Tick() {
            if (IsRunning && CurrentTime > 0) {
                CurrentTime -= GetDeltaTime();
            }

            if (IsRunning && CurrentTime <= 0) {
                Stop();
            }
        }

        public override bool IsFinished => CurrentTime <= 0;
    }
}