using System.Numerics;

namespace ExtendedCharts
{

    public class Entity
    {
        //vanilla
        
        public double Beats; //when this event should be carried out.!
        public string Name;
        public string Object;
        public Vector3 Position, Rotation, Scale;

        public string Color;
        public float Opacity;
 
    }

    public class Shape : Entity
    {
        public string ShapeType;

        public Shape(float _Beats, string _Name, string _ShapeType, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _Color, float _Opacity) //i love y'all but seriously i hope y'all die like i hate you
        {
            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            Name = _Name ?? "New Shape Object";
            Position = _Position;
            Rotation = _Rotation;
            Scale = _Scale;
            Color = _Color ?? "FFFFFF";
            Opacity = _Opacity;
            Object = "Shape";
            ShapeType = _ShapeType ?? "Square";

        }
    }
    public class Image : Entity
    {

        public string Path;

        public Image(float _Beats, string _Name, string _Path, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _Color, float _Opacity) //i love y'all but seriously i hope y'all die like i hate you
        {
            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            Name = _Name ?? "New Image Object";
            Position = _Position;
            Rotation = _Rotation;
            Scale = _Scale;
            Color = _Color ?? "FFFFFF";
            Opacity = _Opacity;
            Object = "Image";
            Path = _Path ?? "None";

        }
    }

    public class Text : Entity
    {

        public string TextContents;

        public Text(float _Beats, string _Name, string _Text, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _Color, float _Opacity) //i love y'all but seriously i hope y'all die like i hate you
        {
            Beats = _Beats;
            if (Beats == 0)
                Beats = 0.01;

            Name = _Name ?? "New Text Object";
            Position = _Position;
            Rotation = _Rotation;
            Scale = _Scale;
            Color = _Color ?? "FFFFFF";
            Opacity = _Opacity;
            Object = "Text";
            TextContents = _Text ?? "Text.Unity.Invalid";

        }
    }
}
