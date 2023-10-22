
using System.Numerics;
using ExtendedCharts;
using ExtendedCharts.ExtendedCharts;
using Newtonsoft.Json;
using System.IO;

/*
Template: Skye
Charter: <put your name here!>

ExtendedCharts Version: 0.11.0 - "Tracks" Update 
*/

class MyMap
{
     string ChartMapFolder = "Path/To/Your/Chart-Map/Folder"; //This will usually be where your game is installed, plus where the Poly Beats_Data folder of the game is, then the StreamingAssets folder, Custom Maps folder, then your map folder.
     string ChartName = "MyNewChart.extendedcharts"; //Going to be saved to the ChartMapFolder.

    #region LittleHandler
    static void Main() 
    {
        MyMap myMap = new MyMap();
        myMap.RegisterNewUserMap();
    }
    #endregion

    void RegisterNewUserMap() 
    {
        /* Here we need to register our Camera and Tracks as objects in the game. */
        #region Base Objects
        //These are objects already in the game scene that you are able to edit.
        #region BaseGameTracks 
        //typically there are 5.
        InheritedTrackAnimations Track1 = new InheritedTrackAnimations();
        InheritedTrackAnimations Track2 = new InheritedTrackAnimations();
        InheritedTrackAnimations Track3 = new InheritedTrackAnimations();
        InheritedTrackAnimations Track4 = new InheritedTrackAnimations();
        InheritedTrackAnimations Track5 = new InheritedTrackAnimations();

        Track1.Name = "Track 1";
        Track2.Name = "Track 2";
        Track3.Name = "Track 3";
        Track4.Name = "Track 4";
        Track5.Name = "Track 5";
                #endregion
        InheritedCameraAnimations Camera = new InheritedCameraAnimations();
        #endregion

        // \/\/\/\/ YOUR CODE GOES HERE 

        // /\/\/\/\ YOUR CODE GOES HERE



        Compiler compiler = new Compiler();
        compiler.CompileScript(ChartMapFolder, ChartName);
    }
}



#region Object Types

namespace ExtendedCharts
{
    public class Shape : InheritedObjectAnimations
    {
        public string ShapeType = default!;

        public Shape(float _Beats, string _Name, string _Shape, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _Color, float _Opacity) //i love y'all but seriously i hope y'all die like i hate you
        {
            VanillaEvents vex = new VanillaEvents();

            vex.Beats = _Beats;
            if (_Beats == 0)
                vex.Beats = 0.01;

            vex.Name = _Name ?? "New Shape Object";
            Name = vex.Name; //for InheritedObjectAnimations;

            vex.Position = _Position;
            vex.Rotation = _Rotation;
            vex.Scale = _Scale;
            vex.Color = _Color ?? "FFFFFF";
            vex.Opacity = _Opacity;
            vex.Object = "Shape";
            vex.Shape = _Shape ?? "Square";
            
BaseObject obj = new BaseObject(vex); //imports VanillaExtendedCharts object and initializes it for the compiler.
        }
    }
    
    public class Image: InheritedObjectAnimations
    {

        public string Path = default!;

        public Image(float _Beats, string _Name, string _Path, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _Color, float _Opacity) //i love y'all but seriously i hope y'all die like i hate you
        {
            VanillaEvents vex = new VanillaEvents();
            vex.Beats = _Beats;
            if (_Beats == 0)
                vex.Beats = 0.01;

            vex.Name = _Name ?? "New Image Object";
            Name = vex.Name; //for InheritedObjectAnimations;

           vex.Position = _Position;
            vex.Rotation = _Rotation;
            vex.Scale = _Scale;
            vex.Color = _Color ?? "FFFFFF";
            vex.Opacity = _Opacity;
            vex.Object = "Image";
            vex.Path = _Path ?? "None";

BaseObject obj = new BaseObject(vex); //imports VanillaExtendedCharts object and initializes it for the compiler.
        }
    }

    public class Text: InheritedObjectAnimations
    {

        public string TextContents = default!;

        public Text(float _Beats, string _Name, string _Text, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _Color, float _Opacity) //i love y'all but seriously i hope y'all die like i hate you
        {
            VanillaEvents vex = new VanillaEvents();
            vex.Beats = _Beats;
            if (_Beats == 0)
                vex.Beats = 0.01;

            vex.Name = _Name ?? "New Text Object";

            Name = vex.Name; //for InheritedObjectAnimations;

            vex.Position = _Position;
            vex.Rotation = _Rotation;
            vex.Scale = _Scale;
            vex.Color = _Color ?? "FFFFFF";
            vex.Opacity = _Opacity;
            vex.Object = "Text";
            vex.Text = _Text ?? "Text.Unity.Invalid";

            BaseObject obj = new BaseObject(vex); //imports VanillaExtendedCharts object and initializes it for the compiler.
        }
    }

    public class Track : InheritedTrackAnimations
    {

        public Track(float _Beats, string _Name, string TrackToImitate, Vector3 _Position, Vector3 _Rotation, Vector3 _Scale, string _TrackColor, string _KeyColor, float _Opacity)
        {
            VanillaEvents vex = new VanillaEvents();
vex.Beats = _Beats;
            if (_Beats == 0)
                vex.Beats = 0.01;

            vex.Name = _Name ?? "New Track";
            Name = vex.Name;
            vex.Position = _Position;
            vex.Rotation = _Rotation;
            vex.Scale = _Scale;
            vex.TrackColor = _TrackColor ?? "C1003F";
            vex.KeyColor = _KeyColor ?? "626262";
            vex.Opacity = _Opacity;
            vex.Object = "Track";

vex.TrackToImitate = TrackToImitate;

            TrackObject obj = new TrackObject(vex);
        }
    }
}

#endregion

#region Notes (Unused For Now)
namespace ExtendedCharts.Notes
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

    
}
#endregion

#region Vanilla

namespace ExtendedCharts
{
    public class VanillaEvents
    {
        public string EventType { get; set; } = default!; // The Event to call (e.g., ChangeColor)

        public double Beats { get; set; } = default!;  // when this event should be carried out.
        public string Object { get; set; } = default!;  // what object to call this on (by name)

        // Animation
        public Vector3 StartPosition { get; set; } = default!; // should be a Vector3 but idc
        public Vector3 EndPosition { get; set; } = default!;
        public Vector3 StartRotation { get; set; } = default!;
        public Vector3 EndRotation { get; set; } = default!;
        public Vector3 StartScale { get; set; } = default!;
        public Vector3 EndScale { get; set; } = default!;
        public string StartColor { get; set; } = default!;
        public string EndColor { get; set; } = default!;
        public float StartFade { get; set; }
        public float EndFade { get; set; }
        public string Easing { get; set; } = default!;

        public float Duration { get; set; }

        // Module Specific...
        public string Text { get; set; } = default!;
        public string Shape { get; set; } = default!;
        public string Track { get; set; } = default!;
        public string TrackToImitate { get; set; } = default!;
        public string PartToEdit { get; set; } = default!;

        public string Path { get; set; } = default!;

        // For Entities
        // vanilla!
        public string Name { get; set; } = default!;
        public Vector3 Position { get; set; } = default!;
        public Vector3 Rotation { get; set; } = default!;
        public Vector3 Scale { get; set; } = default!;
        public string Color { get; set; } = default!;
        public string TrackColor { get; set; } = default!;
        public string KeyColor { get; set; } = default!;
        public float Opacity { get; set; }
    }


    public class BaseObject
    {
        //vanilla!
        public string Name;
        public string Object;
        public Vector3 Position, Rotation, Scale;
        public string Color;
        public float Opacity;
        public double Beats; //when this event should be carried out.

        //module specific...

        public string Text = default!;
        public string Shape = default!;
        public string Path = default!;

        //i hate the entirety of BSMG
        public BaseObject(VanillaEvents vex) //seriously i hope y'all die like i hate you
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
            vex.EventType = "CreateObject";

            if (Object == "Text")
                Text = vex.Text ?? "New Text Object";
            if (Object == "Shape")
                Shape = vex.Shape ?? "Square";
            if (Object == "Image")
                Path = vex.Path ?? "";

            Compiler.AddEvent(vex);
        }
}

	public class TrackObject
	{
		//vanilla!
		public string Name;
		public string TrackToImitate; // 0 - 4, or -1 if you don't want to imitate any
		public Vector3 Position, Rotation, Scale;
		public string TrackColor, KeyColor;
		public float Opacity;
		public double Beats; //when this event should be carried out.

		//i hate the entirety of BSMG
		public TrackObject(VanillaEvents vex) //seriously i hope y'all die like i hate you
		{
			Beats = vex.Beats;
			if (Beats == 0)
				Beats = 0.01;

			Name = vex.Name ?? "New Track";
			Position = vex.Position;
			Rotation = vex.Rotation;
			Scale = vex.Scale;
			TrackColor = vex.TrackColor ?? "C1003F";
			KeyColor = vex.KeyColor ?? "626262";
			Opacity = vex.Opacity;
			TrackToImitate = vex.TrackToImitate;
            vex.EventType = "CreateTrack";
            Compiler.AddEvent(vex);
		}
	}
    #endregion

#region Events

    namespace ExtendedCharts
    {

    public class AnimatePosition
    {
        public double Beats;
        public Vector3 StartPosition, EndPosition;
        public string Object, Easing;
        //If Track or Camera
        public string Track;
        public float Duration;

        public AnimatePosition(VanillaEvents vex)
        {
            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartPosition = vex.StartPosition;
            EndPosition = vex.EndPosition;
            Object = vex.Object ?? "None";
            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            vex.EventType = "ChangePosition";
Compiler.AddEvent(vex);
        }
    }


    public class AnimateRotation
    {
        public double Beats;
        public Vector3 StartRotation, EndRotation;
        public string Object, Easing;
        //If Track or Camera
        public string Track;
        public float Duration;
        public AnimateRotation(VanillaEvents vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            StartRotation = vex.StartRotation;
            EndRotation = vex.EndRotation;
            Object = vex.Object ?? "None";
            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
            vex.EventType = "ChangeRotation";
Compiler.AddEvent(vex);
        }
    }


    public class AnimateScale
    {
        public double Beats;
        public Vector3 StartScale, EndScale;
        //If Track or Camera
        public string Track;
        public string Object, Easing;
        public float Duration;

        public AnimateScale(VanillaEvents vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Object = vex.Object ?? "None";

            StartScale = vex.StartScale; //Camera scale only takes in the first value
            EndScale = vex.EndScale;

            Easing = vex.Easing ?? "Linear";
            Duration = vex.Duration;
            Track = vex.Track;
vex.EventType = "ChangeScale";
Compiler.AddEvent(vex);
        }
    }

        public class AnimateColor
        {
            public double Beats;
            public bool Fade;
            public string StartColor, EndColor;

            public string Track, PartToEdit;

            public string Object, Easing;
            public float Duration;

            public AnimateColor(VanillaEvents vex)
            {

                Beats = vex.Beats;

                StartColor = vex.StartColor ?? "FFFFFF";
                EndColor = vex.EndColor ?? "FFFFFF";
                Object = vex.Object ?? "None";
                Easing = vex.Easing ?? "Linear";
                Duration = vex.Duration;
                Track = vex.Track ?? "Track 1";
                PartToEdit = vex.PartToEdit ?? "Track";
                vex.EventType = "ChangeColor";
                Compiler.AddEvent(vex);
            }
        }


        public class AnimateFade
        {
            public double Beats;
            public float StartFade, EndFade = 1.0f;
            public string Track;
            public string Object, Easing;
            public float Duration;

            public AnimateFade(VanillaEvents vex)
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
                vex.EventType = "ChangeFade";
                Compiler.AddEvent(vex);
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
        public ChangeText(VanillaEvents vex)
        {

            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Object = vex.Object ?? "None";
            NewText = vex.Text;
            Easing = vex.Easing ?? "None";
            Duration = vex.Duration;
vex.EventType = "ChangeText";
Compiler.AddEvent(vex);
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
        public ChangeImage(VanillaEvents vex)
        {
            Object = vex.Object ?? "None";
            Path = vex.Path;
            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            Easing = vex.Easing ?? "None";
            Duration = vex.Duration;
            vex.EventType = "ChangeImage";
            Compiler.AddEvent(vex);
        }
    }

        public class Destroy
    {
        public double Beats;
        public string Object;
        public Destroy(VanillaEvents vex)
        {
            Object = vex.Object ?? "None";
            Beats = vex.Beats;
            if (Beats == 0)
                Beats = 0.01;

            vex.EventType = "Destroy";
            Compiler.AddEvent(vex);
        }
    }

    public class SwitchImitationTrack
	{

		public double Beats;
		public string TrackToEdit;
		public string NewImitator;

		public SwitchImitationTrack(VanillaEvents vex)
		{
			Beats = vex.Beats;
			TrackToEdit = vex.Track;
			NewImitator = vex.TrackToImitate;


                vex.EventType = "SwitchImitationTrack";
                Compiler.AddEvent(vex);
		}
	}

#endregion

# region InternalObjectWorkings

        public class InheritedObjectAnimations
        {
            public string Name = default!; //name of object to edit

            public void ChangePosition(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartPosition = Start;
                vex.EndPosition = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimatePosition position = new AnimatePosition(vex);
            }

            public void ChangeRotation(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartRotation = Start;
                vex.EndRotation = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateRotation rotation = new AnimateRotation(vex);
            }

            public void ChangeScale(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartScale = Start;
                vex.EndScale = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateScale scale = new AnimateScale(vex);
            }

            public void ChangeImage(float Beats, string Path)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name;
                vex.Path = Path;

                ChangeImage image = new ChangeImage(vex);
            }

            public void ChangeText(float Beats, string NewText)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name;
                vex.Text = NewText;

                ChangeText text = new ChangeText(vex);
            }

            public void ChangeColor(float Beats, string Start, string End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartColor = Start;
                vex.EndColor = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateColor color = new AnimateColor(vex);
            }

            public void ChangeFade(float Beats, float Start, float End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartFade = Start;
                vex.EndFade = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateFade fade = new AnimateFade(vex);
            }

             public void Destroy(float Beats)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = Name;

                Destroy obj = new Destroy(vex);
            }

        }

        public class InheritedTrackAnimations
        {
            public string Name = default!; //name of object to edit

            public void ChangePosition(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.Track = Name;
                vex.StartPosition = Start;
                vex.EndPosition = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimatePosition position = new AnimatePosition(vex);
            }

            public void ChangeRotation(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.Track = Name;
                vex.StartRotation = Start;
                vex.EndRotation = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateRotation rotation = new AnimateRotation(vex);
            }

            public void ChangeScale(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.Track = Name;
                vex.StartScale = Start;
                vex.EndScale = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateScale scale = new AnimateScale(vex);
            }

            public void ChangeColor(float Beats, string PartToEdit, string Start, string End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.Track = Name;
                vex.PartToEdit = PartToEdit;
                vex.StartColor = Start;
                vex.EndColor = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateColor color = new AnimateColor(vex);
            }

            public void ChangeFade(float Beats, float Start, float End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.Track = Name;
                vex.StartFade = Start;
                vex.EndFade = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateFade fade = new AnimateFade(vex);
            }

            public void Destroy(float Beats)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track";
                vex.Track = Name;

                Destroy ase = new Destroy(vex);
            }

            public void SwitchImitationTrack(float Beats, string TrackToEdit, string NewImitator) {
                 VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Track";
                vex.Track = Name;

                SwitchImitationTrack switchimi = new SwitchImitationTrack(vex);
            }
        }

        public class InheritedCameraAnimations
        {

            public void ChangePosition(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Camera"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartPosition = Start;
                vex.EndPosition = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimatePosition position = new AnimatePosition(vex);
            }

            public void ChangeRotation(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Camera"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartRotation = Start;
                vex.EndRotation = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateRotation rotation = new AnimateRotation(vex);
            }

            public void ChangeScale(float Beats, Vector3 Start, Vector3 End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Camera"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartScale = Start;
                vex.EndScale = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateScale scale = new AnimateScale(vex);
            }

            public void ChangeColor(float Beats, string Start, string End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Camera"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartColor = Start;
                vex.EndColor = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateColor color = new AnimateColor(vex);
            }

            public void ChangeFade(float Beats, float Start, float End, float Duration, string EasingType)
            {
                VanillaEvents vex = new VanillaEvents();
                vex.Beats = Beats;
                vex.Object = "Camera"; //the game can handle null things i dont think i need to care about fields being null, do I?
                vex.StartFade = Start;
                vex.EndFade = End;
                vex.Duration = Duration;
                vex.Easing = EasingType;

                AnimateFade fade = new AnimateFade(vex);
            }

        }
    }
}

#endregion

#region Utilties
public static class Utilities
{
	public static float Ease(string Ease, float CurrentTimeInTheLerp)
	{
		Easing ease = new Easing();

		if (Ease == "Linear")
			return CurrentTimeInTheLerp;

		if (Ease == "Exponential")
			return ease.Exponential(CurrentTimeInTheLerp);
		if (Ease == "Smooth Step")
			return ease.SmoothStep(CurrentTimeInTheLerp);
		if (Ease == "Smoother Step")
			return ease.SmootherStep(CurrentTimeInTheLerp);
        return CurrentTimeInTheLerp;
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

#endregion

#region Compiler

public class Compiler
{
    

    public static List<VanillaEvents> Events = new List<VanillaEvents>();

public void CompileScript(string MapFolder, string CName)
{
    using (var stream = new MemoryStream())
    using (var writer = new StreamWriter(stream))
    using (var jsonWriter = new JsonTextWriter(writer))
    {
        var serializer = new Newtonsoft.Json.JsonSerializer();
        serializer.Converters.Add(new VanillaEventsConverter());

        foreach (var eventItem in Events)
        {
            serializer.Serialize(jsonWriter, eventItem);
            jsonWriter.WriteRaw("\n"); // Add a newline character after each element
        }

        writer.Flush();
        var jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());

            string Destination = Path.Combine(MapFolder, CName); //not to be confused with the CName you use on websites. Looking at you, StormPacer.

            File.WriteAllText(Destination, "# Generated with the ExtendedSharp Builder at: " + DateTime.Now + "\n" + jsonString);
            Console.WriteLine("Finished with building your chart-map file!");
            Console.WriteLine("Your map can be found here: " + Destination);
            Console.WriteLine('\n' + "Press any key to exit the 'ExtendedSharp Builder' :3");
            Console.ReadKey();
    }
}



    public static void AddEvent(VanillaEvents obj)
    {
        Events.Add(obj);
    }
}


public class VanillaEventsConverter : Newtonsoft.Json.JsonConverter<VanillaEvents>
{

    public override VanillaEvents? ReadJson(JsonReader reader, Type objectType, VanillaEvents? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override void WriteJson(JsonWriter writer, VanillaEvents? value, Newtonsoft.Json.JsonSerializer serializer)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("EventType");
        if (value != null)
        {
            writer.WriteValue(value.EventType);

writer.WritePropertyName("Beats");
            writer.WriteValue(float.Parse(value.Beats.ToString("F4")));

            writer.WritePropertyName("Object");
            writer.WriteValue(value.Object);

            #region SpawnerFunctionFunneler
            if (value.EventType == "CreateObject")
            {
                writer.WritePropertyName("Position");
                Vector3ToFloatArray(value.Position, writer, serializer);
                writer.WritePropertyName("Rotation");
                Vector3ToFloatArray(value.Rotation, writer, serializer);
                writer.WritePropertyName("Scale");
                Vector3ToFloatArray(value.Scale, writer, serializer);
                writer.WritePropertyName("Color");
                writer.WriteValue(value.Color);
                writer.WritePropertyName("Opacity");
                writer.WriteValue(value.Opacity);
                writer.WritePropertyName("Name");
                writer.WriteValue(value.Name);
                // Include other relevant properties based on the context (e.g., Shape, Image, Text)
                if (value.Object == "Shape")
                {
                    writer.WritePropertyName("Shape");
                    writer.WriteValue(value.Shape);

                    // Include other Shape-specific properties here
                }
                else if (value.Object == "Image")
                {
                    writer.WritePropertyName("Path");
                    writer.WriteValue(value.Path);

                    // Include other Image-specific properties here
                }
                else if (value.Object == "Text")
                {
                    writer.WritePropertyName("Text");
                    writer.WriteValue(value.Text);

                    // Include other Text-specific properties here
                }
            }

            if (value.EventType == "CreateTrack")
            {
                writer.WritePropertyName("Position");
                Vector3ToFloatArray(value.Position, writer, serializer);
                writer.WritePropertyName("Rotation");
                Vector3ToFloatArray(value.Rotation, writer, serializer);
                writer.WritePropertyName("Scale");
                Vector3ToFloatArray(value.Scale, writer, serializer);
                writer.WritePropertyName("TrackColor");
                writer.WriteValue(value.TrackColor);
                writer.WritePropertyName("KeyColor");
                writer.WriteValue(value.KeyColor);
                writer.WritePropertyName("Opacity");
                writer.WriteValue(value.Opacity);
                writer.WritePropertyName("Name");
                writer.WriteValue(value.Name);
                writer.WritePropertyName("TrackToImitate");
                writer.WriteValue(value.TrackToImitate);
            }
            #endregion
            #region TransformIJ FunctionFunneler
            if (value.EventType == "ChangePosition")
            {
                writer.WritePropertyName("StartPosition");
                Vector3ToFloatArray(value.StartPosition, writer, serializer);
                writer.WritePropertyName("EndPosition");
                Vector3ToFloatArray(value.EndPosition, writer, serializer);
                writer.WritePropertyName("Duration");
                writer.WriteValue(value.Duration);
                writer.WritePropertyName("Easing");
                writer.WriteValue(value.Easing);

                if(value.Object == "Track")
                {
                    writer.WritePropertyName("Track");
                    writer.WriteValue(value.Track);
                }
            }
            if (value.EventType == "ChangeRotation")
            {
                writer.WritePropertyName("StartRotation");
                Vector3ToFloatArray(value.StartRotation, writer, serializer);
                writer.WritePropertyName("EndRotation");
                Vector3ToFloatArray(value.EndRotation, writer, serializer);
                writer.WritePropertyName("Duration");
                writer.WriteValue(value.Duration);
                writer.WritePropertyName("Easing");
                writer.WriteValue(value.Easing);

                if(value.Object == "Track")
                {
                    writer.WritePropertyName("Track");
                    writer.WriteValue(value.Track);
                }
            }
            if (value.EventType == "ChangeScale")
            {
                writer.WritePropertyName("StartScale");
                Vector3ToFloatArray(value.StartScale, writer, serializer);
                writer.WritePropertyName("EndScale");
                Vector3ToFloatArray(value.EndScale, writer, serializer);
                writer.WritePropertyName("Duration");
                writer.WriteValue(value.Duration);
                writer.WritePropertyName("Easing");
                writer.WriteValue(value.Easing);

                if(value.Object == "Track")
                {
                    writer.WritePropertyName("Track");
                    writer.WriteValue(value.Track);
                }
            }
            #endregion
            #region OverColor FunctionFunneler
            if (value.EventType == "ChangeColor")
            {
                writer.WritePropertyName("StartColor");
                writer.WriteValue(value.StartColor);
                writer.WritePropertyName("EndColor");
                writer.WriteValue(value.EndColor);
                writer.WritePropertyName("Duration");
                writer.WriteValue(value.Duration);
                writer.WritePropertyName("Easing");
                writer.WriteValue(value.Easing);

                if(value.Object == "Track")
                {
                    writer.WritePropertyName("Track");
                    writer.WriteValue(value.Track);
                    writer.WritePropertyName("PartToEdit");
                    writer.WriteValue(value.PartToEdit);
                }
            }

            if (value.EventType == "ChangeFade")
            {
                writer.WritePropertyName("StartFade");
                writer.WriteValue(value.StartFade);
                writer.WritePropertyName("EndFade");
                writer.WriteValue(value.EndFade);
                writer.WritePropertyName("Duration");
                writer.WriteValue(value.Duration);
                writer.WritePropertyName("Easing");
                writer.WriteValue(value.Easing);

                if(value.Object == "Track")
                {
                    writer.WritePropertyName("Track");
                    writer.WriteValue(value.Track);
                }
            }
            #endregion
            #region ExtendedInterface FunctionFunneler
            if (value.EventType == "ChangeText")
            {
                writer.WritePropertyName("Text");
                writer.WriteValue(value.Text);
            }

            if (value.EventType == "ChangeImage")
            {
                writer.WritePropertyName("Path");
                writer.WriteValue(value.Text);
            }
            #endregion
            #region Tracks FunctionFunneler
            if (value.EventType == "SwitchImitationTrack")
            {
                writer.WritePropertyName("TrackToEdit");
                writer.WriteValue(value.Track);
                writer.WritePropertyName("NewImitator");
                writer.WriteValue(value.TrackToImitate);
            }
#endregion
            

            // Add more conditions for other object types as needed
        }
        
writer.WriteEndObject();
    }

    void Vector3ToFloatArray(Vector3 v3, JsonWriter writer, Newtonsoft.Json.JsonSerializer serializer)
    {
        // Start writing the JSON array for the vector
        writer.WriteStartArray();

        serializer.Serialize(writer, v3.X);
        serializer.Serialize(writer, v3.Y);
        serializer.Serialize(writer, v3.Z);

        // End the JSON array for the vector
        writer.WriteEndArray();

        

    }
}



#endregion
