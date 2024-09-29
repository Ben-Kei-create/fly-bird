using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// このクラスは、土管を潜り抜けたら、triggerが機能し、UIでポイントが追加するためのクラスです。
public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;

    // 最初はスコアは0ポイントです。
    int score;

    public void AddScore(int point){
        // 10が渡されたたら、scoreが10になる。
        score += point;
        // String型にしないとおこられる。
        scoreText.text = "Score:" + score.ToString(); // ToString()の使用方法を修正しました。
    }
}