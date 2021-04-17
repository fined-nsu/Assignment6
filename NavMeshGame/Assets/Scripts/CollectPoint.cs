using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Prize")
        {
            Debug.Log("Point collected");
            Destroy(collision.gameObject);
            InfoTracker.score += 10;
        }
        if (collision.gameObject.tag == "Point")
        {
            Debug.Log("Point collected");
            Destroy(collision.gameObject);
            InfoTracker.score += 1;
        }
    }
}
