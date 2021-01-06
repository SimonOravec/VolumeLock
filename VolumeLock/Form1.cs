using AudioSwitcher.AudioApi.CoreAudio;
using NAudio.CoreAudioApi;
using System;
using System.Windows.Forms;

namespace VolumeLock
{
    public partial class Form1 : Form
    {
        private MMDevice audio = new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        CoreAudioDevice cad = new CoreAudioController().DefaultPlaybackDevice;
        public Form1()
        {
            InitializeComponent();

            audio.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
        }

        private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (enabled.Checked) cad.Volume = Decimal.ToInt32(input_vol.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (enabled.Checked) cad.Volume = Decimal.ToInt32(input_vol.Value);
        }

        private void input_vol_ValueChanged(object sender, EventArgs e)
        {
            if (enabled.Checked) cad.Volume = Decimal.ToInt32(input_vol.Value);
        }
    }
}
