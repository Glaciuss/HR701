using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CarService
{
    class Mp3Player:IDisposable 
    {
//        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

//        wplayer.URL = "My MP3 file.mp3";
//wplayer.controls.play();
        public Mp3Player(string fileName)
        {
            const string FORMAT = @"open ""{0}"" type mpegvideo alias MediaFile";
            string command = string.Format(FORMAT, fileName);
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturnString, int iReturnLength, IntPtr hwndCallback);

        public void Dispose()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
