using UnityEngine;
using UnityEngine.UI;

public class CassettePlayer : MonoBehaviour
{
    public AudioSource musicPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPlay()
    {
        Debug.Log("You hearing these tunes?");
        musicPlayer.Play();
    }

    public void OnButtonStop()
    {
        Debug.Log("No tunes anymore.");
        musicPlayer.Stop();
    }
}
