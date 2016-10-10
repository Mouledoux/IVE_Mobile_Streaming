using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour
{
    public GameObject MoveThisObjectWithSound;
    AudioSource audioclip;
    void Start()
    {
        MoveThisObjectWithSound = gameObject;
        //MoveThisObjectWithSound = GameObject.FindGameObjectWithTag("Cube");
        audioclip = gameObject.AddComponent<AudioSource>() as AudioSource;
        audioclip.clip = Microphone.Start("Built-in Microphone", true, 1, 44100);

        //audioclip.volume = 0.001f;
        //audioclip.panStereo = 1;
        audioclip.spatialBlend = 1.0f;
        audioclip.rolloffMode = AudioRolloffMode.Custom;
        audioclip.minDistance = 0.01f;
        audioclip.maxDistance = 1.00f;
    }

    void Update()
    {
        if (audioclip.isPlaying)
        {
        }

        else if (audioclip.clip.loadState == AudioDataLoadState.Loaded)
        {
            audioclip.Play();
            //audioclip.mute = true;
        }
        else
        {
            audioclip.clip = Microphone.Start("Built-in Microphone", true, 1, 44100);
        }

        float y = audioclip.GetSpectrumData(128, 0, FFTWindow.BlackmanHarris)[64] * 1000000;

        if (y >= 10)
        {
            //FindObjectOfType<HelmetController>().play = true;
        }
    }
}
