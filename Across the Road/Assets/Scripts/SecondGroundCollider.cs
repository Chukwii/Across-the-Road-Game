using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGroundCollider : MonoBehaviour
{
    ScorScript Ss;
    PlayersSpawnerScript pss;

    void Start()
    {
        Ss = FindObjectOfType<ScorScript>();
        pss = FindObjectOfType<PlayersSpawnerScript>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "secondPlayer")
        {
            Ss.Score++;
            Destroy(col.gameObject);
            pss.SpawnReal();
        }
    }
}
