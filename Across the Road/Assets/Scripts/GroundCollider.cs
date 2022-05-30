using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
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
        if(col.gameObject.tag == "Player")
        {
            Ss.Score++;
            Destroy(col.gameObject);
            pss.SpawnReverse();
        }
    }
}
