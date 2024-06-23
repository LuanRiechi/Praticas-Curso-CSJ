using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    //criando a classe
    [System.Serializable]//faz com que a classe apareça no editor do gameObject.
    public class Inimigo
    {
        public string nome;
        public int dano;
        public float vida;
        //construtor
        public Inimigo (string Nome, int Dano, float Vida)
        {
            nome = Nome;
            dano = Dano;
            vida = Vida;
        }
    }
    //criando o objeto
    public Inimigo npc;
    // Start is called before the first frame update
    void Start()
    {

    }

}
