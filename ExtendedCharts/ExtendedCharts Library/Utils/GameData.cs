using System;

namespace ExtendedCharts
{
    public class Note
    {
        public int EventType;
        public double SpawnTime;
        public int Track;
    }

    public class HoldNote
    {
        public int EventType;
        public double StartHold, EndHold;

        public int Track;
    }

    public class Easing
    {
        public float Exponential(float CurrentTimeInTheLerp)
        {
            return CurrentTimeInTheLerp * CurrentTimeInTheLerp;
        }
        public float SmoothStep(float CurrentTimeInTheLerp)
        {
            return CurrentTimeInTheLerp * CurrentTimeInTheLerp * (3f - 2f * CurrentTimeInTheLerp);
        }
        public float SmootherStep(float CurrentTimeInTheLerp)
        {

            return CurrentTimeInTheLerp * CurrentTimeInTheLerp * CurrentTimeInTheLerp * (CurrentTimeInTheLerp * (6f * CurrentTimeInTheLerp - 15f) + 10f);
        }
    }
}