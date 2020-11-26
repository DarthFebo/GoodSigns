using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject videoPlayer;
    public int stopVideo;
    
    // Start is called before the first frame update
    void PlayThevideo()
    {
        videoPlayer.SetActive(true);
        Destroy(videoPlayer, stopVideo);
    }
}
