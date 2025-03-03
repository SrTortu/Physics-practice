using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControllerPractice2 : MonoBehaviour
{
    #region Fields

    [SerializeField] private TextMeshProUGUI _deathScoreText;
    [SerializeField] private TextMeshProUGUI _recordJumpScoreText;
    [SerializeField] private TextMeshProUGUI _currentScoreText;

    #endregion

    #region Unity Callbacks

    void Update()
    {
        _deathScoreText.text = "Deaths: " + GameManagerPractice2.gameManagerInstance.deathScore;
        _recordJumpScoreText.text = "Record: " + GameManagerPractice2.gameManagerInstance.recordScore;
        _currentScoreText.text = "Current Score: " + GameManagerPractice2.gameManagerInstance.GetVisitedPlatforms();
    }

    #endregion
}