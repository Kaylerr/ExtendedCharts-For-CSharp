using System;

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
        public float Exponential(float t)
        {
            return t * t;
        }
        public float SmoothStep(float t)
        {
            return t * t * (3f - 2f * t);
        }
        public float SmootherStep(float t)
        {

            return t * t * t * (t * (6f * t - 15f) + 10f);
        }
    }

