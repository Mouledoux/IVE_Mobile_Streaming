using UnityEngine;

public class HelmetController : MonoBehaviour
{
    public GameObject IntroScreen;
    public _8222016 VideoPlayer;

    private float timer = 0;
    private float delay = 1;

    public bool play = false;

    void Update()
    {
        if (play)
        {
            if (IntroScreen.activeSelf)
            {
                if (timer >= delay)//Input.GetKeyUp(KeyCode.F7))
                {
                    IntroScreen.SetActive(false);
                    VideoPlayer.enabled = true;
                    VideoPlayer.PlayPause();
                }
                else
                {
                    timer += Time.deltaTime;
                }
            }

            if (VideoPlayer.GetCurrentVideoMPCState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END && !IntroScreen.activeSelf)
            {
                timer = 0;
                IntroScreen.SetActive(true);
            }

            if (Input.GetKeyUp(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}