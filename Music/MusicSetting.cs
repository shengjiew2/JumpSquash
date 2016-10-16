using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class MusicSetting : MonoBehaviour
{
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource audio { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        audio.clip = sound;
        audio.playOnAwake = true;
        audio.loop = true;
        button.onClick.AddListener(() => MusicControl());
    }

    void MusicControl()
    {
        if (!audio.isPlaying)
        {
            
            audio.Play();
        }
        else
        {
            audio.Stop();
        }
    }
}
