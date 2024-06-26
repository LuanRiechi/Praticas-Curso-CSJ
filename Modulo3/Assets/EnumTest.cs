using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    //Criando o tipo do enum
    public enum Direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }
    //Instanciando o enum, com isso posso definir la na interface qual constante vai ser usada, ex:Norte,sul
    public Direcoes direcoes;
    // Start is called before the first frame update
    void Start()
    {
        //Verificando qual constante foi selecionada dentro do Enum.
        switch (direcoes)
        {
            case Direcoes.Norte:
                Debug.Log("Direcao Norte Selecionado");
                break;
            case Direcoes.Sul:
                Debug.Log("Direcao Sul Selecionado");
                break;
            case Direcoes.Leste:
                Debug.Log("Direcao Leste Selecionado");
                break;
            case Direcoes.Oeste:
                Debug.Log("Direcao Oeste Selecionado");
                break;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
