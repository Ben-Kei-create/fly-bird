using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ぱいぷをじどうてきにせいせいする用
//　一定間隔で生成
public class Pipe : MonoBehaviour
{
    [SerializeField] PipeController pipePrefab;

    float SpawnTime = 2.0f;

    float waitTime = 0.0f;

    // Update is called once per frame
    // ここでは、一定間隔で生成できるようにしている。
    void Update()
    {
        // Time.deltaTimeは、前のフレームからの経過時間を取得することができるものである。
        waitTime += Time.deltaTime;
        // waitTimeとは、ゲーム内の時間を計測している。
        // もし、waitTimeがSpawnTimeを超えたら、Spawn関数を呼び出す。
        // つまり、SpawnTimeはこの場合1秒なので、1秒間隔で生成することができるようになる。
        if(waitTime > SpawnTime)
        {
            // ここでwaitTimeを0.0fにする理由を簡単に説明すると、
            // waitTimeが0.0fにリセットされない場合Spawnメソッドが１秒間隔で呼び出されるようになる。・
            waitTime = 0.0f;
            Spawn();
        }
    }

    // ここで、一定間隔で生成できるようにする。
    // スポーンとは、オブジェクトを生成すること。
    void Spawn()
    {
        // 通常の方法では、真ん中から生成されてしまう。よって、第二引数の部分で場所を指定してあげている。
        // そして、第三引数で回転を指定してあげている。
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}