using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void VideoURL(string url)
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = url;
        videoPlayer.Play();
    }
    
    // Change the VideoURL to NewVideoURL
    // This will allow you to change the video url without having to restart the scene
    public void NewVideoURL(string url)
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = url;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
