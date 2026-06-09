using UnityEngine;
using UnityEngine.UI;

public class CassettePlayer : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioClip music;
    public Slider musicTrack;
    public float musicProgress;
    public float musicLength;
    bool musicPlaying = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicLength = music.length;
        musicProgress = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(musicPlaying)
        {
            musicProgress += Time.deltaTime;
        }
        if (musicProgress >= musicLength)
        {
            musicPlaying = false;
            musicProgress = 0f;
        }

    }

    public void OnButtonPlay()
    {
        Debug.Log("You hearing these tunes?");
        musicPlayer.Play();
        musicPlaying = true;
    }

    public void OnButtonStop()
    {
        Debug.Log("No tunes anymore.");
        musicPlayer.Stop();
        musicPlaying = false;
    }

    
}
