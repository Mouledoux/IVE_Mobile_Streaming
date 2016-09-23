using UnityEngine;

public class HelmetController : MonoBehaviour
{
    public GameObject IntroScreen;
    public _8222016 VideoPlayer;

    private float timer = 0;
    private float delay = 10;
    

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F7))
        {
            VideoPlayer.PlayPause();
        
            if (IntroScreen.activeSelf)
            {
                IntroScreen.SetActive(false);
            }
        }

        if (VideoPlayer.GetCurrentVideoMPCState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            IntroScreen.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}