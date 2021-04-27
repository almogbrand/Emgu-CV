using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using static emgu_test.CTRL_Algorithm;

namespace emgu_test
{
    public partial class Form1 : Form
    {

        public Mat srcMat, desMat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(ProcType)))
            {
                var control = new CTRL_Algorithm();
                control.Type = (ProcType)item;                
                UI_lst_MethodsList.Controls.Add(control);
            }
            ArrangeControls(UI_lst_MethodsList);
            PrepareDragAndDrop();
        }
        private void PrepareDragAndDrop()
        {
            UI_lst_MethodsList.AllowDrop = true;
            UI_lst_SelectedMethods.AllowDrop = false;

            UI_lst_MethodsList.DragEnter += Panel_DragEnter;
            UI_lst_SelectedMethods.DragEnter += Panel_DragEnter;

            UI_lst_MethodsList.DragDrop += Panel_DragDrop;
            UI_lst_SelectedMethods.DragDrop += Panel_DragDrop;

            foreach (CTRL_Algorithm control in UI_lst_MethodsList.Controls)
            {
                control.OnMouseDown += control_MouseDown;                
            }
        }
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as CTRL_Algorithm).DoDragDrop((sender as CTRL_Algorithm), DragDropEffects.Copy);
        }
        private void Panel_DragEnter(object sender, DragEventArgs args)
        {
            args.Effect = DragDropEffects.Copy;
        }
        private void Panel_DragDrop(object sender, DragEventArgs args)
        {
            var targetPanel = (Panel)sender;
            var srcCtrl = ((CTRL_Algorithm)args.Data.GetData(typeof(CTRL_Algorithm)));
            var srcPanel = srcCtrl.Parent;

            // Illegal drag & drop
            if (targetPanel == UI_lst_MethodsList && srcPanel == UI_lst_MethodsList) return;
            
            // Select methods from methods list to selected list
            if (srcPanel == UI_lst_MethodsList && targetPanel == UI_lst_SelectedMethods)
            {
                var newCtrl = new CTRL_Algorithm() { Type = ((CTRL_Algorithm)args.Data.GetData(typeof(CTRL_Algorithm))).Type};
                newCtrl.OnMouseDown += control_MouseDown;
                newCtrl.onValueChanged += () =>
                {
                    ResetImageBox();
                    ApplyMethods(targetPanel);
                };
                targetPanel.Controls.Add(newCtrl);
                ArrangeControls((Panel)targetPanel);
                ApplyMethods((Panel)targetPanel);
            }

            // Removing methods from selected list
            if (targetPanel== UI_lst_MethodsList && srcPanel == UI_lst_SelectedMethods)
            {
                srcPanel.Controls.Remove(srcCtrl);
                ArrangeControls((Panel)srcPanel);

                // rearrange methods effects 
                ResetImageBox();
                ApplyMethods((Panel)srcPanel);
            }

            // Change order of selected methods 
            if (targetPanel == UI_lst_SelectedMethods && srcPanel == UI_lst_SelectedMethods)
            {
                var p = targetPanel.PointToClient(Cursor.Position);
                foreach (CTRL_Algorithm ctrl in targetPanel.Controls)
                {                    
                    if (ctrl.Bounds.Contains(p))
                    {
                        var l = ctrl.Location;
                        ctrl.Location = srcCtrl.Location;                        
                        srcCtrl.Location = l;                        
                        break;
                    }
                }

                // rearrange methods effects 
                ResetImageBox();
                ApplyMethods((Panel)srcPanel);
            }
        }
        private void ResetImageBox()
        {
            desMat = srcMat;
            ibBig.Image = desMat;
        }
        private void ArrangeControls(Panel panel)
        {
            var cnt = 0;
            var top = 0; 
            
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var ctrl = (CTRL_Algorithm)panel.Controls[i];
                ctrl.Location = new Point(0, top);
                switch (panel.Name)
                {
                    case "UI_lst_MethodsList" :
                        ctrl.Color = cnt++ % 2 == 0 ? Color.Cyan : Color.AliceBlue;
                        break;
                }
                top += ctrl.Height + 1;
            }
        }
        private void ApplyMethods(Panel panel)
        {
            if (srcMat == null) return;
            desMat = srcMat;
            for(int i=0; i<panel.Controls.Count; i++)
            {
                CTRL_Algorithm ctrl = (CTRL_Algorithm)panel.Controls[i];
                desMat = ctrl.MethodsProcess(desMat);
            }
            ibBig.Image = desMat;
        }
        private void UI_cmd_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UI_lst_SelectedMethods.AllowDrop = true;
                srcMat = new Mat(dialog.FileName);
                desMat = new Mat(srcMat.Size, srcMat.Depth, srcMat.NumberOfChannels);
                desMat = srcMat;
                ibOrigin.Image = srcMat;
                ibBig.Image = srcMat;
            }
        }

    }
}