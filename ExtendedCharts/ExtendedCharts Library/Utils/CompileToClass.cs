using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

namespace ExtendedCharts
{
    public class AnimatePosition
    {
        public double Beats;
        public Vector3 StartPosition, EndPosition;
        public string Object, Easing;
        //If Track or Camera
        public int Track;
        public float Duration;
        
        public AnimatePosition(Vanilla vex)
        {
            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartPosition = new Vector3(vex.StartPosition[0], vex.StartPosition[1], vex.StartPosition[2]);
            EndPosition = new Vector3(vex.EndPosition[0], vex.EndPosition[1], vex.EndPosition[2]);
            Object = vex.Object ?? "None";
            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            
        }
    }


    public class AnimateRotation
    {
        public double Beats;
        public Vector3 StartRotation, EndRotation;
        public string Object, Easing;
        //If Track or Camera
        public int Track;
        public float Duration;
        public AnimateRotation(Vanilla vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartRotation = new Vector3(vex.StartRotation[0], vex.StartRotation[1], vex.StartRotation[2]);
            EndRotation = new Vector3(vex.EndRotation[0], vex.EndRotation[1], vex.EndRotation[2]);
            Object = vex.Object ?? "None";
            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            
        }
    }


    public class AnimateScale
    {
        public double Beats;
        public Vector3 StartScale, EndScale;
        //If Track or Camera
        public int Track;
        public string Object, Easing;
        public float Duration;

        public AnimateScale(Vanilla vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Object = vex.Object ?? "None";

            StartScale = new Vector3(vex.StartScale[0], vex.StartScale[1], vex.StartScale[2]); //camera only ever takes the FIRST VALUE - the X so to say.
            EndScale = new Vector3(vex.EndScale[0], vex.EndScale[1], vex.EndScale[2]);

            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            
        }
    }


    public class AnimateColor
    {
        public double Beats;
        public bool Fade;
        public string StartColor, EndColor;

        public int Track;

        public string Object, Easing;
        public float Duration;

        public AnimateColor(Vanilla vex)
        {

            Beats = vex.Beats;

            StartColor = vex.StartColor ?? Utilities.ToHex(Color.white);
            EndColor = vex.EndColor ?? Utilities.ToHex(Color.white);
            Object = vex.Object ?? "None";
            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            
        }
    }


    public class AnimateFade
    {
        public double Beats;
        public float StartFade, EndFade = 1.0f;
        public int Track;
        public string Object, Easing;
        public float Duration;

        public AnimateFade(Vanilla vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartFade = vex.StartFade;
            EndFade = vex.EndFade;
            Object = vex.Object ?? "None";
            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            
        }
    }


    //yes im using classes for this shit, shut up
    public class ChangeText
    {
        public double Beats;
        public string Object;
        public string NewText = "Text";
        public bool Fade;
        public string Easing;
        public float Duration;
        public ChangeText(Vanilla vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Object = vex.Object ?? "None";
            NewText = vex.Text;
            Fade = vex.Fading;
            Easing = vex.Easing ?? "None";
            Duration = vex.Duration;
            
        }
    }


    public class ChangeImage
    {
        public double Beats;
        public string Path = "A Default/Path";
        public string Object;
        public bool Fade;
        public string Easing;
        public float Duration;
        public ChangeImage(Vanilla vex)
        {

            Object = vex.Object ?? "None";
            Path = vex.Path;
            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Fade = vex.Fading;
            Easing = vex.Easing ?? "None";
            Duration = vex.Duration;

            try
            {
                Utility.Utilties.AddImage(Path); //the AddImage function will call isDoneWithAll itself.
            }
            catch
            {
                
            }
        }
    }
}
