using UnityEngine;
using System.Collections;

public class PlatformFallDown : MonoBehaviour {
    public string nameHolder;
    public int waitingTime = 1;

    GameObject holder;

    void Start(){
        holder = GameObject.Find(nameHolder);
    }

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        yield return new WaitForSeconds(waitingTime);
        GameObject.Destroy(holder);
    }
}
