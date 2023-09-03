using System;

class Utilities
{
	public static float Ease(string Ease, float t)
	{
		Easing ease = new Easing();

		if (Ease == "Linear")
			return t;

		if (Ease == "Exponential")
			return ease.Exponential(t);
		if (Ease == "Smooth Step")
			return ease.SmoothStep(t);
		if (Ease == "Smoother Step")
			return ease.SmootherStep(t);


		return t;
	}
}