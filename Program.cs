using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merage_Audio_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fist = new AudioFileReader(@"C:\Users\Windows\Downloads\Mot-Doan-Tinh-Hoai-Ngoc-Truyen-Ky-OST-Phuc-Kien-Dang-Cap-Nhat.wav");
            var second = new AudioFileReader(@"C:\Users\Windows\Downloads\ConXinSamHoi-HoQuangHieu-3203975.mp3");
            var playlist = fist.FollowedBy(TimeSpan.FromSeconds(1),second);
            WaveFileWriter.CreateWaveFile16(@"C:\Users\Windows\Downloads\NewAudio.wav", playlist);
            Console.Write("Merge audio successfully!");
            Console.ReadKey();

        }
    }
}
