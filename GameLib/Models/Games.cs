using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Games
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string HeroImage { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public Color AccentColorStart { get; set; }
        public Color AccentColorEnd { get; set; }
        public List<string> Images { get; set; }
        public string ReviewsUrl { get; set; }
        public string Steam { get; set; }
        public string EpicGames { get; set; }
        public string Ubisoft { get; set; }
        public string Xbox { get; set; }
        public string RockstarGames { get; set; }
        public string GOG { get; set; }

        public Brush Background
        {
            get
            {
                var gradientStops = new GradientStopCollection();
                gradientStops.Add(new GradientStop(AccentColorStart, 0.0f));
                gradientStops.Add(new GradientStop(AccentColorEnd, 1.0f));

                var bgBrush = new LinearGradientBrush(
                    gradientStops,
                    new Point(0.0, 0.0),
                    new Point(1.0, 1.0));

                return bgBrush;
            }
        }
    }
}