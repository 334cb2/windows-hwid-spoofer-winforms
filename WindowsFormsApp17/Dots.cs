using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Dots : Control
    {
        private Timer animationTimer;
        private List<Dot> dots;
        private Random random;
        private int dotCount = 20;
        private float dotSpeed = 1.0f;
        private int dotSize = 10;
        private Color dotColor = Color.White;
        private Color backgroundColor = Color.Black;
        private int animationFPS = 60;
        private int fadeInDuration = 60;
        private int fadeOutDuration = 60;

        public Dots()
        {
            InitializeComponent();
            InitDots();
        }

        private void InitDots()
        {
            this.DoubleBuffered = true;
            dots = new List<Dot>();
            random = new Random();

            animationTimer = new Timer
            {
                Interval = 1000 / animationFPS
            };
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            for (int i = 0; i < dotCount; i++)
            {
                AddNewDot();
            }
        }

        [Category("Appearance"), Description("Background color of the control.")]
        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                this.Invalidate();
            }
        }

        [Category("Behavior"), Description("Speed of the dots rising.")]
        public float DotSpeed
        {
            get => dotSpeed;
            set => dotSpeed = Math.Max(0.1f, value);
        }

        [Category("Appearance"), Description("Size of the dots.")]
        public int DotSize
        {
            get => dotSize;
            set => dotSize = value;
        }

        [Category("Appearance"), Description("Color of the dots.")]
        public Color DotColor
        {
            get => dotColor;
            set => dotColor = value;
        }

        [Category("Behavior"), Description("Number of dots.")]
        public int DotCount
        {
            get => dotCount;
            set
            {
                dotCount = value;
                AdjustDotCount();
            }
        }

        [Category("Behavior"), Description("Animation frames per second.")]
        public int AnimationFPS
        {
            get => animationFPS;
            set
            {
                animationFPS = value;
                animationTimer.Interval = 1000 / animationFPS;
            }
        }

        [Category("Behavior"), Description("Fade-in duration (in frames).")]
        public int FadeInDuration
        {
            get => fadeInDuration;
            set => fadeInDuration = value;
        }

        [Category("Behavior"), Description("Fade-out duration (in frames).")]
        public int FadeOutDuration
        {
            get => fadeOutDuration;
            set => fadeOutDuration = value;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            for (int i = dots.Count - 1; i >= 0; i--)
            {
                dots[i].Y -= dots[i].Speed;
                dots[i].Age++;

                if (dots[i].Age <= fadeInDuration)
                {
                    dots[i].Alpha = (int)(255 * (dots[i].Age / (float)fadeInDuration));
                }
                else if (dots[i].Age >= (dots[i].LifeSpan - fadeOutDuration))
                {
                    int fadeOutAge = dots[i].Age - (dots[i].LifeSpan - fadeOutDuration);
                    dots[i].Alpha = (int)(255 * (1 - (fadeOutAge / (float)fadeOutDuration)));
                }
                else
                {
                    dots[i].Alpha = 255;
                }

                if (dots[i].Y < -dots[i].Size || dots[i].Age > dots[i].LifeSpan)
                {
                    dots.RemoveAt(i);
                    AddNewDot();
                }
            }

            this.Invalidate();
        }

        private void AddNewDot()
        {
            int initialYPosition = random.Next(this.Height / 2, this.Height);
            dots.Add(new Dot
            {
                X = random.Next(0, this.Width),
                Y = initialYPosition,
                Size = dotSize,
                Speed = dotSpeed + (float)random.NextDouble() * 0.5f,
                Alpha = 0,
                Age = 0,
                LifeSpan = (int)(this.Height / dotSpeed) + fadeOutDuration
            });
        }

        private void AdjustDotCount()
        {
            while (dots.Count < dotCount)
            {
                AddNewDot();
            }

            while (dots.Count > dotCount)
            {
                dots.RemoveAt(0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;


            g.Clear(backgroundColor);

            foreach (var dot in dots)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(dot.Alpha, dotColor)))
                {
                    g.FillEllipse(brush, dot.X - dot.Size / 2, dot.Y - dot.Size / 2, dot.Size, dot.Size);
                }
            }
        }
    }

    public class Dot
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Size { get; set; }
        public float Speed { get; set; }
        public int Alpha { get; set; }
        public int Age { get; set; }
        public int LifeSpan { get; set; }
    }
}
