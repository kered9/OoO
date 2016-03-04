using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;

public class Audio : MonoBehaviour {
    public List<AudioClip> audioClips = new List<AudioClip>();
    public List<GameObject> cues = new List<GameObject>();

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void CueMusic(int i)
    {
        int index = i;
        AudioSource audio = GetComponent<AudioSource>();
        switch (index)
        {
            case 0:
                audio.clip = audioClips[index];
                break;
            case 1:
                audio.clip = audioClips[index];
                break;
            case 2:
                audio.clip = audioClips[index];
                break;
            case 3:
                audio.clip = audioClips[index];
                break;
            case 4:
                audio.clip = audioClips[index];
                break;
            default:
                audio.clip = audioClips[5];
                break;

        }

        audio.Play();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == cues[0])
            CueMusic(0);

        else if (col.gameObject == cues[1])
            CueMusic(1);

        else if (col.gameObject == cues[2])
            CueMusic(2);

        else if (col.gameObject == cues[3])
            CueMusic(3);

        else if (col.gameObject == cues[4])
            CueMusic(4);

        Debug.Log("Hit!");
    }
}
