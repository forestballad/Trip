using UnityEngine;
using System.Collections;

public class QiuFeiReposition : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        Application.LoadLevel(Application.loadedLevelName);
    }
}
