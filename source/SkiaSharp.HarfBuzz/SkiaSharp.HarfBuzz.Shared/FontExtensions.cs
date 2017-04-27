﻿using System;

using HarfBuzzSharp;

namespace SkiaSharp.HarfBuzz
{
	public static class FontExtensions
	{
		public static SKSizeI GetScale(this Font font)
		{
			if (font == null)
			{
				throw new ArgumentNullException(nameof(font));
			}

			int x, y;
			font.GetScale(out x, out y);
			return new SKSizeI(x, y);
		}

		public static void SetScale(this Font font, SKSizeI scale)
		{
			if (font == null)
			{
				throw new ArgumentNullException(nameof(font));
			}

			font.SetScale(scale.Width, scale.Height);
		}
	}
}
