using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;
    public Text playerScoreText;
    public Text computerScoreText;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        ResetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
