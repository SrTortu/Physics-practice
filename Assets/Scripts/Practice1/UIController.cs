using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Fields
    public TextMeshProUGUI scoreText;
    

    #endregion
    
    #region Unity Callbacks
    void Update()
    {
        scoreText.text = "Knoked Down Boxes: " + GameManager.gameManagerInstance.score;
    }
    
    #endregion
}
