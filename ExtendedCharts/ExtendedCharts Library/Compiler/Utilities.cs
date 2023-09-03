using ExtendedCharts;

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
}