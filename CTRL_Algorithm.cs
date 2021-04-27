using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu.CV;

namespace emgu_test
{
    public partial class CTRL_Algorithm : UserControl
    {
        public delegate void OnMouseDownEvent(object sender, MouseEventArgs e);
        public event OnMouseDownEvent OnMouseDown;

        public delegate void onValueChangedEvent();
        public event onValueChangedEvent onValueChanged;

        public CTRL_Algorithm()
        {
            InitializeComponent();

            // Preview of method effect 
            panel1.MouseEnter += (o, e) =>
            {
                imageBox1.Visible = !imageBox1.Visible;
            };

            panel1.MouseLeave += (o, e) =>
            {
                imageBox1.Visible = !imageBox1.Visible;
            };

            trackBar1.Maximum = 255;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 3;
            trackBar1.SmallChange = 2;

            groupBox1.MouseDown += (o, e) => { OnMouseDown?.Invoke(this, e); };
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is Panel && ctrl.Name != "panel1")
                {
                    ctrl.MouseDown += (o, e) => { OnMouseDown?.Invoke(this, e); };
                    foreach (Control c in ctrl.Controls)
                    {
                        if (c is RadioButton)
                            (c as RadioButton).CheckedChanged += (o, e) =>
                             {
                                 if ((o as RadioButton).Checked) onValueChanged.Invoke();
                             };
                        if (c is TextBox)
                            (c as TextBox).TextChanged += (o, e) => onValueChanged.Invoke();
                        if (c is TrackBar)
                            (c as TrackBar).ValueChanged += (o, e) =>  onValueChanged.Invoke();
                    }
                }
            }


        }

        public Mat MethodsProcess(Mat src)
        {
            Mat res = new Mat(src.Size, src.Depth, src.NumberOfChannels);
            try
            {


                switch (_procType)
                {
                    case ProcType.Rotation:
                        CvInvoke.Rotate(src, res, rbtnRight.Checked ? Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise : Emgu.CV.CvEnum.RotateFlags.Rotate90CounterClockwise);
                        break;

                    case ProcType.Flip:
                        CvInvoke.Flip(src, res, rbtnVertical.Checked ? Emgu.CV.CvEnum.FlipType.Vertical : Emgu.CV.CvEnum.FlipType.Horizontal);
                        break;

                    case ProcType.Greyscale:
                        CvInvoke.CvtColor(src, res, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                        break;

                    case ProcType.Canny:
                        CvInvoke.Canny(src, res, Convert.ToDouble(txtCannyThr1.Text), Convert.ToDouble(txtCannyThr2.Text));
                        break;

                    case ProcType.Soble:
                        CvInvoke.Sobel(src, res, Emgu.CV.CvEnum.DepthType.Cv8U, 1, 0, 3);
                        break;

                    case ProcType.Threshold:
                        txtThr.Text = "" + trackBar1.Value;
                        CvInvoke.Threshold(src, res, 128, Convert.ToDouble(txtThr.Text), Emgu.CV.CvEnum.ThresholdType.Binary);
                        break;

                    default:

                        break;

                }
            }
            catch (Exception)
            {
                return null;
            }
            imageBox1.Image = res;
            return res;
        }

        private ProcType _procType;
        private Panel _activePanel;
        public ProcType Type
        {
            get { return _procType; }
            set
            {
                _procType = value;
                var str = Enum.GetName(typeof(ProcType), _procType);
                foreach (Control ctrl in groupBox1.Controls)
                {
                    if (!(ctrl is Panel) || ctrl.Name == "panel1") continue;
                    ctrl.Visible = ctrl.Name == $"UI_pnl_{str}";

                    if (ctrl.Visible)
                    {
                        _activePanel = (Panel)ctrl;
                        groupBox1.Size = new Size(ctrl.Size.Width, ctrl.Size.Height + 20 + panel1.Height);
                        ctrl.Location = new Point(0, 20);
                        groupBox1.BackColor = ctrl.BackColor;
                        ctrl.Dock = DockStyle.Fill;
                        _activePanel.BringToFront();
                    }
                    groupBox1.Text = _procType.ToString();
                }
                Width = groupBox1.Width + 5;
                Height = groupBox1.Height + 5;
            }
        }
        public Color Color
        {
            get { return groupBox1.BackColor; }
            set
            {
                groupBox1.BackColor = value;
                _activePanel.BackColor = value;
            }
        }

        public enum ProcType
        {
            Rotation,
            Flip,
            Greyscale,
            Canny,
            Soble,
            Threshold
        }
                
    }
}
