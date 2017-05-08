using UnityEngine;
using UnityEngine.Recorder.FrameRecorder;
using UTJ.FrameCapturer;

namespace UnityEngine.Recorder.FrameRecorder.Example
{
    [ExecuteInEditMode]
    public class MP4RecorderSettings : ImageRecorderSettings
    {
        public string m_BaseFileName  = "mp4File";
        public string m_DestinationPath = "Recorder";
        public fcAPI.fcMP4Config m_MP4EncoderSettings = fcAPI.fcMP4Config.default_value;

        public override bool isValid
        {
            get
            {
                return base.isValid && !string.IsNullOrEmpty(m_DestinationPath) && !string.IsNullOrEmpty(m_BaseFileName);
            }
        }
    }
}
