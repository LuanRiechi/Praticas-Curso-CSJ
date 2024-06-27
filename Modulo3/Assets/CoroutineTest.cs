using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        //chamando a função de coroutine
        StartCoroutine("Test");
    }

    //função de coroutine, serve para dar pausa ao executar um comando
    IEnumerator Test()
    {
        Debug.Log("Executando coroutine");
        //nesse retorno posso colocar alguma pausa
        yield return new WaitForSeconds(5f);
        Debug.Log("Executando Coroutine depois de 5s");
    }
}
