using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    [System.Serializable]
    public class Inimigo
    {
       public string Nome;
       public int Dano;
       public int Level;
    }

    public List<Inimigo> inimigos = new List<Inimigo>();

    private void Start()
    {
        inimigos.Add(new Inimigo());
        Estaticos.estatico.quantidadeVida();
    }
}
