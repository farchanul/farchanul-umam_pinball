using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    private void Start(){
    }

	public void PlayVFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}
}
