using System.Collections;
using System.Collections.Generic;
using System.Numerics;

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

        public AnimatePosition(VanillaEvents _
        {
            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartPosition = _StartPosition;
            EndPosition = _EndPosition;
            Object = _Object ?? "None";
            Easing = _Easing ?? "Linear";
            Duration = _Duration;
            Track = _Track;

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
        public AnimateRotation(VanillaEvents _
        {

            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartRotation = _StartRotation;
            EndRotation = _EndRotation;
            Object = _Object ?? "None";
            Easing = _Easing ?? "Linear";
            Duration = _Duration;
            Track = _Track;

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

        public AnimateScale(VanillaEvents _
        {

            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            Object = _Object ?? "None";

            StartScale = _StartScale; //Camera scale only takes in the first value
            EndScale = _EndScale;

            Easing = _Easing ?? "Linear";
            Duration = _Duration;
            Track = _Track;

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

        public AnimateColor(VanillaEvents _
        {

            Beats = _Beats;

            StartColor = _StartColor ?? "FFFFFF"; //default value is Color.white in HexCode
            EndColor = _EndColor ?? "FFFFFF"; //default value is Color.white in HexCode
            Object = _Object ?? "None";
            Easing = _Easing ?? "Linear";
            Duration = _Duration;
            Track = _Track;

        }
    }


    public class AnimateFade
    {
        public double Beats;
        public float StartFade, EndFade = 1.0f;
        public int Track;
        public string Object, Easing;
        public float Duration;

        public AnimateFade(VanillaEvents _
        {

            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartFade = _StartFade;
            EndFade = _EndFade;
            Object = _Object ?? "None";
            Easing = _Easing ?? "Linear";
            Duration = _Duration;
            Track = _Track;

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
        public ChangeText(VanillaEvents _
        {

            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            Object = _Object ?? "None";
            NewText = _Text;
            Fade = _Fading;
            Easing = _Easing ?? "None";
            Duration = _Duration;

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
        public ChangeImage(VanillaEvents _
        {
            Object = _Object ?? "None";
            Path = _Path;
            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            Fade = _Fading;
            Easing = _Easing ?? "None";
            Duration = _Duration;
        }
    }
}
