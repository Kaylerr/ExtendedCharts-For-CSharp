using System.Numerics;

namespace ExtendedCharts
{
    class OverColor
    {
        public void ChangeColor(float Beats, string Object, string Start, string End, float Duration, string EasingType)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object; //the game can handle null things i dont think i need to care about fields being null, do I?
            _StartColor = Start;
            _EndColor = End;
            _Duration = Duration;
            _Easing = EasingType;

            AnimatePosition position = new AnimatePosition(_;
        }

        public void ChangeOpacity(float Beats, string Object, float Start, float End, float Duration, string EasingType)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object; //the game can handle null things i dont think i need to care about fields being null, do I?
            _StartFade = Start;
            _EndFade = End;
            _Duration = Duration;
            _Easing = EasingType;

            AnimatePosition position = new AnimatePosition(_;
        }
    }
}