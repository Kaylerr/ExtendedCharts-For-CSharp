
namespace ExtendedCharts
{
    class ExtendedInterface
    {
        public void ChangeImage(float Beats, string Object, string Path)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object;
            _Path = Path;

            ChangeImage image = new ChangeImage(_;
        }

        public void ChangeText(float Beats, string Object, string NewText)
        {
            VanillaEvents _= new VanillaEvents();
            _Beats = Beats;
            _Object = Object;
            _Text = NewText;

            ChangeText text = new ChangeText(_;
        }
    }
}
