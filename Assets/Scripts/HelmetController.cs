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
                gameObject.GetComponent<AudioSource>().Stop();
                IntroScreen.SetActive(false);

                Vector3 rot = Camera.main.transform.localEulerAngles;
                rot.x = rot.z = 0;
                rot.y -= 90;
                VideoPlayer.gameObject.transform.localEulerAngles = rot;
            }
        }

        if (VideoPlayer.GetCurrentVideoMPCState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            gameObject.GetComponent<AudioSource>().Play();
            IntroScreen.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}