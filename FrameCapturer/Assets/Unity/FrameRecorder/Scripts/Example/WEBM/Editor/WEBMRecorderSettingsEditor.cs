using System;
using UnityEditor;
using UnityEngine.Recorder.FrameRecorder.Example;
using UnityEngine;

namespace UnityEditor.Recorder.FrameRecorder.Example
{
    [CustomEditor(typeof(WEBMRecorderSettings))]
    [RecorderEditor(typeof(WEBMRecorder))]
    public class WEBMRecorderSettingsEditor : DefaultImageRecorderSettingsEditor
    {
        public override Vector2 minSize
        {
            get { return new Vector2(400, 370); }
        }

        protected override void OnEncodingGui()
        {
            base.OnEncodingGui();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_WebmEncoderSettings"), true);
        }

        protected override void OnOutputGui()
        {
            var settingsObj = serializedObject.targetObject as WEBMRecorderSettings;

            settingsObj.m_DestinationPath = DestinationDirectoryGui(settingsObj.m_DestinationPath);
            m_LayoutHelper.AddStringProperty("File name", serializedObject, () => settingsObj.m_BaseFileName);
        }
    }
}
