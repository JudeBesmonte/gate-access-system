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
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Tesseract;

namespace GateAccessSystem
{
    public partial class frm_licensePlate : Form
    {
        private VideoCapture _capture;
        private Image<Bgr, byte> _currentFrame;
        public frm_licensePlate()
        {
            InitializeComponent();
            InitializeCamera();
        }
        private void InitializeCamera() 
        {
            
            _capture = new VideoCapture();
            _capture.ImageGrabbed += ProcessFrame;
            _capture.Start();
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            _currentFrame = _capture.QueryFrame().ToImage<Bgr, byte>();
            LP_pictureBox.Image = _currentFrame.ToBitmap();
        }
        private void LP_pictureBox_Click(object sender, EventArgs e)
        {
            
        }
        private void LP_btn_capture_Click(object sender, EventArgs e)
        {
            if (_currentFrame != null)
            {
                try
                {
                    using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                    {
                        using (var grayFrame = _currentFrame.Convert<Gray, byte>())
                        {
                            var ocrResult = engine.Process(grayFrame.ToBitmap());
                            LP_textbox_platenumber.Text = ocrResult.GetText().Trim();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in OCR processing: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No image captured.");
            }
        }

        private void LP_button_record_Click(object sender, EventArgs e)
        {
            // Placeholder for future implementation of database recording functionality.
            MessageBox.Show("Record button clicked. Database functionality will be added later.");
        }
        private void frm_licensePlate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Stop();
                _capture.Dispose();
            }
        }
    }
}
