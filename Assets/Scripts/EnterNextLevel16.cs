using UnityEngine;
using System.Collections;

public class EnterNextLevel16 : MonoBehaviour {
    public int waitingTime;
    public string levelname;

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        yield return new WaitForSeconds(waitingTime);
        Application.LoadLevel(levelname);
    }
}
