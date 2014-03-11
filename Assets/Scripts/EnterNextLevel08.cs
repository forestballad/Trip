using UnityEngine;
using System.Collections;

public class EnterNextLevel08 : MonoBehaviour {
    public int touched = 0;
    public string levelname;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (touched == 4)
        {
            Application.LoadLevel(levelname);
        }
    }
}
