using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public float multiplier;
    public Collider bola;
    public Color color;
    private Animator animator;
    public audiomanager audioManager;
    public VFXManager VFXManager;
    public scorecontroller scoreManager;
    public int score;

    void Start(){
        GetComponent<Renderer>().material.color = color;
        animator = GetComponent<Animator>();
    }
	
	private void OnCollisionEnter(Collision collision)
	{
		
        if (collision.collider == bola)
        {
            scoreManager.AddScore(score);
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            animator.SetTrigger("bumperhit");
            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);
        }
    }
}
