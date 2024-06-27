using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptExercicio : MonoBehaviour
{
    public float Velocidade;
    public float Rotacao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimento para cima e baixo
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // fazendo o objeto se mover a uma velocidade no eixo x negativo, pois meu cubo esta posicionado todo torto.
            // time.deltaTime faz essa velocidade ser lisa, e mais suave.
            transform.Translate(new Vector3(-1f,0,0) * Velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //deixando o vector 3 positivo consigo ir para traz com o cubo.
            transform.Translate(new Vector3(1f, 0, 0) * Velocidade * Time.deltaTime);
        }

        //Criando rotação para ele virar
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Rotacao * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Rotacao * Time.deltaTime);
        }

    }
}
