using UnityEngine;
using System.Collections;

public class HelmetController : MonoBehaviour
{
    public GameObject IntroScreen;
    public _8222016 VideoPlayer;

    private float timer = 0;
    private float delay = 10;

	void Update ()
    {
	    if(timer >= delay)//Input.GetKeyUp(KeyCode.F7))
        {
            if(IntroScreen.activeSelf)
            {
                IntroScreen.SetActive(false);
                VideoPlayer.enabled = true;
                VideoPlayer.PlayPause();
            }
        }
        else
        {
            timer += Time.deltaTime;
        }

        if(VideoPlayer.GetCurrentVideoMPCState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            timer = 0;
            IntroScreen.SetActive(true);
        }

        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
