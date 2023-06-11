using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text finalScoreText;

    // Update is called once per frame
    void Update()
    {
        if (player != null && scoreText != null)
        {
            scoreText.text = "Score: " + player.position.z.ToString("0");
            finalScoreText.text = scoreText.text;
        }
    }

    void OnDisable()
    {
        // Save the final score
        if (finalScoreText != null && int.TryParse(finalScoreText.text, out int finalScore))
        {
            // Display the final score
            Debug.Log("Your final score is " + finalScore);
        }
        /*else
        {
            Debug.LogError("Failed to parse final score.");
        }*/
    }
}
