using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranformeERotation : MonoBehaviour
{
    public float Velocidade;
    public float Rotacao;
    // Update is called once per frame
    void Update()
    {
        //movimento para cima e baixo
        if (Input.GetKey(KeyCode.UpArrow)) { 
            // fazendo o objeto se mover a uma velocidade no eixo z, o time.deltaTime faz essa velocidade ser lisa, e mais suave.
            transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //vector 3 negativo pois se com ele possitivo eu vou pra cima, negativo vou na direção oposta.
            transform.Translate(-Vector3.forward * Velocidade * Time.deltaTime);
        }

        //Criando rotação para ele virar
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(Vector3.down * Rotacao * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Rotacao * Time.deltaTime);
        }
    }
}
