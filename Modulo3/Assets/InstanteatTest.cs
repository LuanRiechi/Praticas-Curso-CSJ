using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanteatEDestroyer : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Quando o usuario precionar a tecla i, vai ser instanciado o preFab dentro do objeto que esta rodando esse script
        if (Input.GetKeyDown(KeyCode.I)){
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
