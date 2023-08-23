using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EvaNew
{
    public partial class FormHeart : MetroForm
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private bool goBack = false;

        private int iZoom = 15;
        private int mySpeed { get; set; }
        private int myZoom { get; set; } = 15;
        private int myParticle { get; set; }
        private int myArea { get; set; }

        private int pWidth;

        private int pHeight;

        private Brush myBrush { get; set; } = Brushes.Pink;

        private List<string> colors = new List<string>();

        public FormHeart()
        {
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
            SetData();
            StartTimer();
        }

        private void SetData()
        {
            var props = typeof(Brushes).GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                colors.Add(props[i].Name);
            }
            metroComboBoxColor.DataSource = colors;
            metroComboBoxColor.SelectedIndex = colors.IndexOf("Red");
            metroComboBoxColor.SelectedItem = colors[colors.IndexOf("Red")];

            pWidth = metroPanelHeart.Width;
            pHeight = metroPanelHeart.Height;

            metroTrackBarDotsArea.Maximum = pWidth > pHeight ? pWidth:pHeight;

            mySpeed = metroTrackBarSpeed.Value;
            myParticle = metroTrackBarDotsNum.Value;
            myArea = metroTrackBarDotsArea.Value;
        }

        private void metroButtonSettingSwitch_Click(object sender, EventArgs e)
        {
            if (metroButtonSettingSwitch.Text.Equals("Hide Setting"))
            {
                metroPanelSetting.Visible = false;
                metroButtonSettingSwitch.Text = "Show Setting";
            }
            else if (metroButtonSettingSwitch.Text.Equals("Show Setting"))
            {
                metroPanelSetting.Visible = true;
                metroButtonSettingSwitch.Text = "Hide Setting";
            }
        }

        private void metroComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            myBrush = (Brush)typeof(Brushes).GetProperty(metroComboBoxColor.Text).GetValue(null);
        }

        private void draw()
        {
            iZoom += goBack ? -1 : 1;
            if (iZoom >= (myZoom + 2) || iZoom <= (myZoom - 3))
                goBack = !goBack;
            Bitmap bmp = new Bitmap(pWidth, pHeight);
            Graphics g = Graphics.FromImage(bmp);
            Random random = new Random();
            for (int i = 0; i < myParticle * 100; i++)
            {
                double t = random.NextDouble() * 2 * Math.PI;
                double x = 16 * (Math.Pow(Math.Sin(t), 3));
                double y = -(13 * Math.Cos(t) - 5 * Math.Cos(2 * t) - 2 * Math.Cos(3 * t) - Math.Cos(4 * t));
                x *= iZoom;
                y *= iZoom;
                x += pWidth / 2;
                y += pHeight / 2;
                if (0 < x && x < pWidth && 0 < y && y < pHeight)
                    g.FillEllipse(myBrush, new Rectangle((int)(x), (int)(y), 10, 10));
                if (i % 2 == 0)
                {
                    int xDelta = random.Next(-myArea, myArea);
                    int yDelta = random.Next(-myArea, myArea);
                    int newX = (int)(x + xDelta);
                    int newY = (int)(y + yDelta);
                    if (0 < newX && newX < pWidth && 0 < newY && newY < pHeight) 
                    {
                        g.FillEllipse(myBrush, new Rectangle(newX, newY, 5, 5));
                    }
                }
                else if (i % 3 == 0)
                {
                    int xDelta = random.Next(-myArea - 20, myArea + 20);
                    int yDelta = random.Next(-myArea - 20, myArea + 20);
                    int newX = (int)(x + xDelta);
                    int newY = (int)(y + yDelta);
                    if (0 < newX && newX < pWidth && 0 < newY && newY < pHeight) 
                    {
                        g.FillEllipse(myBrush, new Rectangle(newX, newY, 5, 5));
                    }
                }   
            }
            metroPanelHeart.BackgroundImage = bmp;
        }

        void TimerTicking(object sender, EventArgs e)
        {
            draw();
        }

        private void StartTimer()
        {
            mySpeed = metroTrackBarSpeed.Value;
            timer.Interval = 1000 - mySpeed;
            timer.Tick += TimerTicking;
            timer.Enabled = true;
        }
        private void StopTimer()
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
            }
        }

        private void FormHeart_Resize(object sender, EventArgs e)
        {
            StopTimer();

            pWidth = metroPanelHeart.Width;
            pHeight = metroPanelHeart.Height;

            StartTimer();
        }

        private void FormHeart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseReason.UserClosing == e.CloseReason && this.WindowState != FormWindowState.Minimized)
            {
                FormMessageBox mbox = new FormMessageBox();
                DialogResult dResult = mbox.ShowBox("Exit", "Does Eva want to stop for some rest?");
                if (dResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (dResult == DialogResult.No || dResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void metroTrackBarSpeed_MouseLeave(object sender, EventArgs e)
        {
            StopTimer();
            StartTimer();
        }

        private void metroTrackBarDotsNum_MouseLeave(object sender, EventArgs e)
        {
            myParticle = metroTrackBarDotsNum.Value;
        }

        private void metroTrackBarDotsArea_MouseLeave(object sender, EventArgs e)
        {
            myArea = metroTrackBarDotsArea.Value;
        }
    }
}
