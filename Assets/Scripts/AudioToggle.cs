using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
	public AudioSource audioSource;

	// Start is called before the first frame update
	public void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void ToggleSound()
	{
        	if(!audioSource.isPlaying)
		{
			audioSource.Play();
		}
		else
		{
			audioSource.Pause();
		}
	}
}
