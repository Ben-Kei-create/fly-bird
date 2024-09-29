using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    bool isGameOver = false;

    private void Update()
    {
        if(isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //リトライ　= 同じシーンを読み込む
                string scene = SceneManager.GetActiveScene().name; // 変数宣言の修正
                SceneManager.LoadScene(scene); // 正しいシーン名を使用
            }
        }
    }

    public void GameOver()
    {
        // GameOverパネルを表示！
        gameOverPanel.SetActive(true);
        isGameOver = true; // 変数名のタイプミスを修正
    }
}