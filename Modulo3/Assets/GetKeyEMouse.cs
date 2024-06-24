using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyEMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tecla A precionada");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Tecla B precionada");
        }
        if (Input.GetKeyUp(KeyCode.C)){
            Debug.Log("Tecla C precionada");
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Funciona quando eu clico no objeto com o colisor");
    }

    private void OnMouseEnter()
    {
        Debug.Log("é chamado quando eu passo o mouse por cima do objeto");
    }

    private void OnMouseDrag()
    {
        Debug.Log("É chamado quando clica no colisor e mantem precionado o mouse");
    }
}
