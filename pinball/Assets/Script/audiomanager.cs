using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM() 
    { 
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition) 
{ 
	// memunculkan prefabnya pada posisi sesuai dengan parameternya
	GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
}

}
