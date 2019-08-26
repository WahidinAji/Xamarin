using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VideoPlayer
{
    public partial class MainPage : ContentPage
    {
        string videoUrl = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4";
        //string videoUrl = "https://www.youtube.com/watch?v=uYaakilLkkk";
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayStop_Clicked(object sender, EventArgs e)
        {
            if (PlayStopButton.Text == "Play")
            {
                CrossMediaManager.Current.Play(videoUrl, MediaFileType.Video);
                PlayStopButton.Text = "Stop";
            }
            else if (PlayStopButton.Text == "Stop")
            {
                CrossMediaManager.Current.Stop();
                PlayStopButton.Text = "Play";
            }
        }
    }
}
