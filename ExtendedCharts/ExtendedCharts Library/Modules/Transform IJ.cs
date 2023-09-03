using System.Numerics;

namespace ExtendedCharts
{
    class TransformIJ
    {
        public void ChangePosition(float Beats, string Object, Vector3 Start, Vector3 End, float Duration, string EasingType)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object; //the game can handle null things i dont think i need to care about fields being null, do I?
            _StartPosition = Start;
            _EndPosition = End;
            _Duration = Duration;
            _Easing = EasingType;

            AnimatePosition position = new AnimatePosition(_;
        }

        public void ChangeRotation(float Beats, string Object, Vector3 Start, Vector3 End, float Duration, string EasingType)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object; //the game can handle null things i dont think i need to care about fields being null, do I?
            _StartRotation = Start;
            _EndRotation = End;
            _Duration = Duration;
            _Easing = EasingType;

            AnimateRotation rotation = new AnimateRotation(_;
        }

        public void ChangeScale(float Beats, string Object, Vector3 Start, Vector3 End, float Duration, string EasingType)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object; //the game can handle null things i dont think i need to care about fields being null, do I?
            _StartScale = Start;
            _EndScale = End;
            _Duration = Duration;
            _Easing = EasingType;

            AnimateScale scale = new AnimateScale(_;
        }
    }


}