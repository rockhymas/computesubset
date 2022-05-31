using System;
using System.Windows;
using System.Windows.Media;

namespace ComputeSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeface = new Typeface(new FontFamily("Segoe UI"), FontStyles.Normal, FontWeights.SemiBold, FontStretches.Normal);

            if (!typeface.TryGetGlyphTypeface(out var glyphTypeFace))
            {
                return;
            }

            glyphTypeFace.ComputeSubset(glyphTypeFace.AdvanceHeights.Keys);

            Console.WriteLine("Success!");
        }
    }
}
