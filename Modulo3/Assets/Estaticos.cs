using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estaticos : MonoBehaviour
{
    public static Estaticos estatico;
    public int Vida = 5;

    private void Start()
    {
        estatico = this;
    }

    public void quantidadeVida()
    {
        Debug.Log("Quantidade de vida é: " + Vida);
    }
}
