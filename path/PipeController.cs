using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    // スピードをかんたんにちょうせつする
    [SerializeField] float moveSpeed; 

    // みぎからひだりへうごかす→transform!

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right *moveSpeed * Time.deltaTime;
    }
// ここで、当たり判定をつくる。
// Collider を設定する。Colliderとは、当たり判定をつけるためのコンポーネントである。
// Rigidbodyを設定
private void OnCollisionEnter2D(Collision2D collusion)
{
    Debug.Log("あたり判定です。");
    Destroy(this.gameObject);
}

}