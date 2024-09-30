using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMusic : MonoBehaviour
{
	public static ContinueMusic bgmusic;

	private void Awake()
	{
		if (bgmusic != null)
		{
			Destroy(gameObject);
		}
		else
		{
			bgmusic = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
