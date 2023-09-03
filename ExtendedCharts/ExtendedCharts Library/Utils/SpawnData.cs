using System.Numerics;

namespace ExtendedCharts
{
    public class VanillaEvents
    {
        public string EventType; //The Event to call (e.g, ChangeColor)

        public double Beats; //when this event should be carried out.
        public string Object; //what object to call this on (by name)

        //Animation
        public Vector3 StartPosition, EndPosition; //should be a Vector3 but idc
        public Vector3 StartRotation, EndRotation;
        public Vector3 StartScale, EndScale;
        public string StartColor, EndColor;
        public float StartFade, EndFade;
        public string Easing;
        public bool Fading;

        public float Duration;

        //Module Specific...
        public string Text;
        public string Shape;
        public int Track;
        public string Path;

        // => For Entities
        //vanilla!
        public string Name;
        public Vector3 Position, Rotation, Scale;
        public string Color;
        public float Opacity;
    }

   
}