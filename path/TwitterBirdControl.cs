using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterBirdControl : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] float upSpeed; 
    [SerializeField] GameManager gameManager;
    bool isDead = false;
    Rigidbody2D rb2D;

    // Awakeは、ゲームオブジェクトが生成された時に１度だけ呼ばれるメソッド。
    private void Awake()
    {
        this.rb2D = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        if(isDead)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb2D.velocity = Vector3.up * upSpeed;
        }
        //　もし、このオブジェクトのY軸が6以上、-6以下になるとゲームオーバーになる。
        if(transform.position.y > 6 || transform.position.y < -6)
        {
            gameManager.GameOver();
            isDead = true;
        }
    }

    // GameOverの実装→これは、当たり判定のメソッドになります。
    // どのタイミングで、何をするのかを設定する必要がある。
    // このクラスは、pipeに当たったら、ゲームオーバーになり、『ゲームオーバー』という文字をUIに表示する。
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isDead)
        {
            return;
        }
        gameManager.GameOver();
        isDead = true;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isDead)
        {
            return;
        }
        score.AddScore(10);
    }
}
