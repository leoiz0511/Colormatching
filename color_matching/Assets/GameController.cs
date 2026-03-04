using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textScore;
    private int score = 0;

    [SerializeField]
    private GameObject panelResult;
    [SerializeField]
    private TextMeshProUGUI textResultScore;
    [SerializeField]
    private TextMeshProUGUI textHighScore;

    public bool IsGameOver { private set; get; }

    private void Awake()
    {
        IsGameOver = false;
    }

    public void IncreaseScore()
    {
        score++;
        textScore.text = $"Score {score}";
    }

    public void GameOver()
    {
        // 현재 상태를 게임오버로 설정 (CubeChecker 클래스에서 점수 계산을 하지 않도록)
        IsGameOver = true;
        // 스테이지의 점수 출력 Text UI 비활성화
        textScore.enabled = false;
        //결과 화면 Result UI 활성화
        panelResult.SetActive(true);

        // 기존에 등록된 최고 점수 불러오기
        int highScore = PlayerPrefs.GetInt("HighScore");

        if (highScore > score)
        {
            textHighScore.text = $"High Score {highScore}";
        }
        else
        {
            // 현재 점수를 최고 점수 정보로 저장하기
            PlayerPrefs.SetInt("HighScore", score);

            textHighScore.text = $"High Score {score}";
        }

        textResultScore.text = $"Score {score}";
    }
}