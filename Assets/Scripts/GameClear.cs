using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

class GameClear : MonoBehaviour
{
    Transform myTransform;
    public Text gameClearMessage;
    bool isGameClear = false;

    void Start()
    {
        // Transformコンポーネントを保持しておく
        myTransform = transform;
    }

    void Update()
    {
        // 子供がいなくなったらゲームを停止する
        if (myTransform.childCount == 0) {
            gameClearMessage.text = "Game Clear";
            Time.timeScale = 0f;
            isGameClear = true;
        }
        if(isGameClear && Input.GetButtonDown("Submit")) {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Play");
	    }
    }
}