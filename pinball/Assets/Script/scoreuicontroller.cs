using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreuicontroller : MonoBehaviour
{
    public TMP_Text scoreText;
    public scorecontroller scoreManager;

    private void Update()
    {
    scoreText.text = scoreManager.score.ToString();
    }
}
