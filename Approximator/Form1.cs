using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Approximator
{
    public partial class ApproxForm : Form
    {
        private List<Point> PointsXY = new List<Point> { };
        private int movePointPos = -1;
        private bool buildFunction = false;
        public ApproxForm()
        {
            InitializeComponent();
            //ApproxSettings-->
            ApproxChart.ChartAreas.Add(new ChartArea("Approximation functions"));
            //X-->
            ApproxChart.ChartAreas[0].AxisX.Minimum = 0;
            ApproxChart.ChartAreas[0].AxisX.Maximum = 7;
            ApproxChart.ChartAreas[0].AxisX.Interval = 1;
            ApproxChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ApproxChart.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            //Y-->
            ApproxChart.ChartAreas[0].AxisY.Minimum = 0;
            ApproxChart.ChartAreas[0].AxisY.Maximum = 5;
            ApproxChart.ChartAreas[0].AxisY.Interval = 1;
            ApproxChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            ApproxChart.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Triangle;
            //
            Series series = new Series("Datum line");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Black;
            series.ChartArea = "Approximation functions";
            series.Points.AddXY(0, 0);
            ApproxChart.Series.Add(series);
            //            
        }
        //Добавление точки-->
        private void ApproxChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Местоположение курсора Chart OX OY
            var OX = ApproxChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            var OY = ApproxChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
            OX = OXTransform(OX);
            if (PointsXY.Any())
            {
                if (OX != -1)
                {
                    bool AddPoint = true;
                    foreach (var point in PointsXY)
                    {
                        if (point.GetX() == OX)
                        {
                            AddPoint = false;
                        }
                    }
                    if (AddPoint)
                    {
                        PointsXY.Add(new Point(OX, OY));
                    }
                }
            }
            else
            {
                PointsXY.Add(new Point(OX, OY));
            }
            DrawPoints();
        }
        //Перетаскивание точки-->
        private void ApproxChart_MouseDown(object sender, MouseEventArgs e)
        {
            if (PointsXY.Any())
            {
                HitTestResult hit = ApproxChart.HitTest(e.X, e.Y);
                if (hit.ChartElementType == ChartElementType.DataPoint)
                {
                    var OX = ApproxChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                    if (OX > 0.5 && OX < 5.5)
                    {
                        movePointPos = hit.PointIndex;
                    }
                    
                }
            }
        }
        private void ApproxChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (movePointPos > -1 && movePointPos < 6)
            {
                PointsXY[movePointPos].SetY(ApproxChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                DrawPoints();
                DrawFunction();
            }
        }
        private void ApproxChart_MouseUp(object sender, MouseEventArgs e)
        {
            if (movePointPos > -1)
            {
                movePointPos = -1;
            }
        }
        //Кнопки управления-->
        private void BuildButton_Click(object sender, EventArgs e)
        {
            buildFunction = true;
            DrawFunction();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (PointsXY.Any())
            {
                PointsXY.Clear();
                ApproxChart.Series.Remove(ApproxChart.Series.FindByName("Points"));
                ApproxChart.Series.Remove(ApproxChart.Series.FindByName("Lagrange"));
                ApproxChart.Series.Remove(ApproxChart.Series.FindByName("LeastSquares"));
                ApproxChart.Series.Remove(ApproxChart.Series.FindByName("Extrapolation"));
                buildFunction = false;
            }
        }
        //Рисование точек и графиков-->
        private void DrawPoints()
        {
            if (ApproxChart.Series.FindByName("Points") != null)
            {
                ApproxChart.Series.Remove(ApproxChart.Series.FindByName("Points"));
            }
            Series series = new Series("Points");
            series.ChartType = SeriesChartType.Point;
            series.ChartArea = "Approximation functions";
            if (PointsXY.Any())
            {
                foreach (var point in PointsXY)
                {
                    series.Points.AddXY(point.GetX(), point.GetY());
                }
                ApproxChart.Series.Add(series);
            }
        }
        private void DrawFunction()
        {
            if (buildFunction)
            {
                if (CheckBLagrange.Checked && PointsXY.Count == 5)
                {
                    Lagrange lagrange = new Lagrange(sortPointList(PointsXY));
                    if (ApproxChart.Series.FindByName("Lagrange") != null)
                    {
                        ApproxChart.Series.Remove(ApproxChart.Series.FindByName("Lagrange"));
                    }
                    Series series = new Series("Lagrange");
                    series.ChartType = SeriesChartType.Line;
                    series.ChartArea = "Approximation functions";
                    for (double x = 0; x < ApproxChart.ChartAreas[0].AxisX.Maximum; x += 0.01)
                    {
                        series.Points.AddXY(x, lagrange.getResult(x));
                    }
                    ApproxChart.Series.Add(series);
                }
                if (CheckBLS.Checked && PointsXY.Count == 5)
                {
                    LeastSquares leastSquares = new LeastSquares(sortPointList(PointsXY));
                    if (ApproxChart.Series.FindByName("LeastSquares") != null)
                    {
                        ApproxChart.Series.Remove(ApproxChart.Series.FindByName("LeastSquares"));
                    }
                    Series series = new Series("LeastSquares");
                    series.ChartType = SeriesChartType.Line;
                    series.ChartArea = "Approximation functions";
                    for (double x = 0; x < ApproxChart.ChartAreas[0].AxisX.Maximum; x += 0.01)
                    {
                        series.Points.AddXY(x, leastSquares.getResult(x));
                    }
                    ApproxChart.Series.Add(series);
                }
                DrawExtrapolation();
            }
        }
        private void DrawExtrapolation()
        {
            if (PointsXY.Count == 5)
            {
                if (ApproxChart.Series.FindByName("Extrapolation") != null)
                {
                    ApproxChart.Series.Remove(ApproxChart.Series.FindByName("Extrapolation"));
                }
                Series series = new Series("Extrapolation");
                series.ChartType = SeriesChartType.Point;
                series.ChartArea = "Approximation functions";
                if (CheckBLagrange.Checked)
                {
                    Lagrange lagrange = new Lagrange(sortPointList(PointsXY));
                   
                    series.Points.AddXY(0, lagrange.getResult(0));
                    series.Points.AddXY(6, lagrange.getResult(6));
                    
                }
                if (CheckBLS.Checked)
                {
                    LeastSquares leastSquares = new LeastSquares(sortPointList(PointsXY));
                    series.Points.AddXY(0, leastSquares.getResult(0));
                    series.Points.AddXY(6, leastSquares.getResult(6));
                }
                ApproxChart.Series.Add(series);
            }
        }
        //
        private double OXTransform(double OX)
        {
            int intOX = Convert.ToInt32(OX * 10);
            if (intOX <= 5 || intOX > 55)
            {
                return -1;
            }
            else if (intOX % 10 <= 5)
            {
                return intOX / 10;
            }
            else if (intOX % 10 > 5)
            {
                return intOX / 10 + 1;
            }
            else return -1;
        }
        private List<Point> sortPointList(List<Point> Points)
        {
            if (Points.Count > 1)
            {
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    for (int j = i + 1; j < Points.Count; j++)
                    {
                        if (Points[i].GetX() > Points[j].GetX())
                        {
                            Point temp = Points[i];
                            Points[i] = Points[j];
                            Points[j] = temp;
                        }
                    }
                }
                return Points;
            }
            else return Points;
        }

        
    }
}
