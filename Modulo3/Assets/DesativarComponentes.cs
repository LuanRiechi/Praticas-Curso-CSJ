using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarComponentes : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        // Desativa todo o GameObject da cena
        //obj.SetActive(false);

        //Desativa apenas o componente de script do objeto
        //obj.GetComponent<Arrays>().enabled= false;

        if (obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
