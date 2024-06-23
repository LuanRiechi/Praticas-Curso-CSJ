using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //como encontrar um objeto na cena atravez de um array
    public GameObject[] Players;

    // Start is called before the first frame update
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");

        foreach(GameObject P in Players)
        {
            Debug.Log(P.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
