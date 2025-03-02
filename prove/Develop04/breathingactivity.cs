using System;

namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity",
            "This activity helps you relax by guiding you through deep breathing.") { }

        public override void Run()
        {
            Start();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("\nBreathe in... ");
                PauseWithAnimation(3);
                Console.Write("Breathe out... ");
                PauseWithAnimation(3);
            }

            End();
        }
    }
}
