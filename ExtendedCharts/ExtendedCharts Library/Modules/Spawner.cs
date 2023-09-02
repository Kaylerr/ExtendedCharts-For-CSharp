using System;

namespace ExtendedCharts
{
    public class Vanilla
    {
        public string EventType; //The Event to call (e.g, ChangeColor)
        public string Object; //the object type to instantiate

        public double Beats; //when this event should be carried out.
        public string Name; //when we create an object, what should we name it? i wanna name it lenny :)

        public float[] Position, Rotation, Scale; //the base of Unity to fill a Transform component...
        public string Color;
        public float Opacity;

        //Animation
        public float[] StartPosition, EndPosition;
        public float[] StartRotation, EndRotation;
        public float[] StartScale, EndScale;
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


    }



    public class BaseObject
    {
        //vanilla!
        public string Name;
        public string Object;
        public float[] Position, Rotation, Scale;
        public string Color;
        public float Opacity;
        public double Beats; //when this event should be carried out.

        //module specific...

        public string Text;
        public string Shape;
        public int Track;
        public string Path;

        //i hate the entirety of BSMG
        public BaseObject(Vanilla vex) //seriously i hope y'all die like i hate you
        {
            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Name = vex.Name ?? "Object";
            Position = vex.Position;
            Rotation = vex.Rotation;
            Scale = vex.Scale;
            Color = vex.Color ?? "FFFFFF";
            Opacity = vex.Opacity;
            Object = vex.Object ?? "Shape";

            if (Object == "Text")
                Text = vex.Text ?? "New Text Object";
            if (Object == "Shape")
                Shape = vex.Shape ?? "Square";
            if (Object == "Image")
                Path = vex.Path ?? "";

        }



    }
}