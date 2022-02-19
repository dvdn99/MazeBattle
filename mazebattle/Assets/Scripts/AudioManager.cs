using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance {get; private set; }

    public AudioSource introPlayer;
    public AudioSource musicPlayer;
    public AudioSource gameOverPlayer;

    bool isPlayingMusic;
    bool isPlayingIntro;
    
    private void Awake() {
        Instance = this;
    }

    private void Start() {
        Mute();
        PlayIntro();
    }

    public void PlayMusic()
    {
        if(!isPlayingMusic)
        {
            Mute();
            musicPlayer.Play();
            isPlayingMusic = true;
        }
    }

    public void PlayIntro()
    {
        if(!isPlayingIntro)
        {
            Mute();
            introPlayer.Play();
            isPlayingIntro = true;
        }
    }

    public void PlayGameOver()
    {

        Mute();
    
        gameOverPlayer.Play();
    }

    public void Mute()
    {
        isPlayingIntro = false;
        isPlayingMusic = false;
        introPlayer.Stop();
        musicPlayer.Stop();
        gameOverPlayer.Stop();
        
    }


    public void ContinueIntro()
    {
        if(!isPlayingIntro)
        {
            isPlayingIntro = true;
            introPlayer.Play();
        }
    }

    public void ContinueMusic()
    {
        if(!isPlayingMusic)
        {
            isPlayingMusic = true;
            musicPlayer.Play();
        }
    }
    public void ContinueGameOver()
    {
        gameOverPlayer.Play();
    }
}
