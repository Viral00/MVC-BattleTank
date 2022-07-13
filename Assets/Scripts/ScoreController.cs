using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text scoretext;
    public PlayerHealth playerHealth;

    private void Update()
    {
        playerHealth.TankWin += ViewText;
    }

    private void ViewText()
    {
        scoretext.text = "You    Win!";
    }
}
