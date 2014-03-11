using UnityEngine;
using System.Collections;

public class EnterNextLevel09 : MonoBehaviour {
    public int fall = 0;
    public string levelname;

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    void Update() {
        if (Application.loadedLevelName != "level09") {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        fall++;
        if (fall == 10)
        {
            Application.LoadLevel(levelname);
        }
        GameObject qiufei = GameObject.Find("QiuFei");
        qiufei.transform.position = new Vector2(-5.5f, -2.5f);
    }
}
