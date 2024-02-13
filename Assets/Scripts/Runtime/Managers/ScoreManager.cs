using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    #region Self Veriables
    
    #region Serialized Veriables

    [SerializeField] private Text scoreText;

    #endregion

    #region Public Veriables

    public static int Score;
    
    #endregion
    #endregion
   
    
    void Update()
    {
        scoreText.text = "Score: " + Score;
    }
}