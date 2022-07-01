﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
<<<<<<< HEAD

namespace Healt_Declaration_Form
{
    public partial class QRCodeScanner : Form
    {
        public QRCodeScanner()
=======
using ZXing.Aztec;

namespace Healt_Declaration_Form
{
    public partial class CodeScanner : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public CodeScanner()
>>>>>>> 0b894a91089cbfc687320cff6baa1bcaf18ee110
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Startbtn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CameraBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            Timer.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScannerBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRCodeScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CameraBox.Items.Add(filterInfo.Name);
            CameraBox.SelectedIndex = 0;
        }

        private void QRCodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ScannerBox.Image != null)
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)ScannerBox.Image);
                if (result != null)
                {
                    DecodeBox.Text = result.ToString();
                    Timer.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.SignalToStop();
                        captureDevice.WaitForStop();
                    }
                }
            }
=======
        private void CodeScanner_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                CameraBox1.Items.Add(Device.Name);

            CameraBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void strbtn_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CameraBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScannerBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning ==true)
                FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)ScannerBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if(decoded != "")
                {
                    DecodedText.Text = decoded;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
>>>>>>> 0b894a91089cbfc687320cff6baa1bcaf18ee110
        }
    }
}
