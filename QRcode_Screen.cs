using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace NHS_SelfCheckIn
{
    public partial class QRcode_Screen : Form
    {
        ComfirmCancelReschedule_Screen f1 = new ComfirmCancelReschedule_Screen();
        public QRcode_Screen()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private void VisualLink_Click(object sender, EventArgs e)
        {
            // Leave blank 
        }

        private void QRcode_Screen_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                WebcamDevice.Items.Add(filterInfo.Name);
            WebcamDevice.SelectedIndex = 0;

            captureDevice = new VideoCaptureDevice(filterInfoCollection[WebcamDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            VisualLink.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Screen f1 = new Main_Screen();
            f1.Show();
        }

        private void Prebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppFinderForPatients f1 = new AppFinderForPatients();
            f1.Show();
        }

        private void Next1btn_Click(object sender, EventArgs e)
        {
          //f1.Show();
          //this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VisualLink.Image != null) 
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)VisualLink.Image);
                if (result != null)
                {
                    ComfirmCancelReschedule_Screen.SetValueForText1 = result.ToString();
                    timer1.Stop();
                    //if (captureDevice.IsRunning)
                    //captureDevice.Stop();
                    //MessageBox.Show("Your QR code has been sucsefully read you may press 'ok' then 'next'");
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void QRcode_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }

        private void QRcode_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //i(captureDevice.IsRunning)
                captureDevice.Stop();
        }
    }

}
