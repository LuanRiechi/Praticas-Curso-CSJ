using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// importanto biblioteca para acessar elementos de interface de usuario
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    //valor da minha vida
    public float Vida;
    public Image BarraDeVida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //minha barra de vida vai receber o valor da minha vida /100 pois a o fillamout recebe valores de 0 a 1
        //dessa forma eu pego o valor da minha vida e divido por 100 para receber os valores compativeis.
        BarraDeVida.fillAmount = Vida / 100;
    }
}
