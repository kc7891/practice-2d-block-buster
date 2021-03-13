﻿using UnityEngine;
// Textコンポーネントを使用する場合に必要
using UnityEngine.UI;

class ResetText : MonoBehaviour
{
    void Start()
    {
        // アクセスは1回きりなので、フィールド変数を用意しなくてもいい
        Text myText = GetComponent<Text>();
        // textに空の文字列を設定する
        myText.text = "";
    }
}