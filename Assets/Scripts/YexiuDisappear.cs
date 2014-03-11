using UnityEngine;
using System.Collections;

public class YexiuDisappear : MonoBehaviour {
    GameObject nextLevelTrigger;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        nextLevelTrigger = GameObject.Find("NextLevelTrigger");
        nextLevelTrigger.GetComponent<EnterNextLevel08>().touched ++;
    }
}
