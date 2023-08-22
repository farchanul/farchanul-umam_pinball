using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerremp : MonoBehaviour
{
    public float score;
    public Collider bola;
    public scorecontroller scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
        //tambah skor kalau terkena bola
        scoreManager.AddScore(score);
        }
    }
}
