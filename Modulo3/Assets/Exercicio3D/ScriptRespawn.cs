using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRespawn : MonoBehaviour
{
    //Criando uma lista para conter os gameObjects de paredes, pois assim eu posso escolher randomicamente, qual gameObject
    //sera spawnado na cena
    public List<GameObject> Paredes = new List<GameObject>();
    //variavel para definir o tempo de respaw das paredes
    private float spawTempo = 5f;

    void Start()
    {
        
    }
    //variavel para receber o tempo de segundos do jogo
    float TempoCont;
    void Update()
    {
        //recebendo o segundos do jogo
        TempoCont += Time.deltaTime;
        //quando o tempo de jogo chegar no tempo de respaw eu gero uma parede e zero o contador de tempo do jogo
        if (TempoCont >= spawTempo) 
        {
            //instancio um elemento de paredes aleatorio, dentre todos da minha lista
            //depois passo a position e rotation do meu objeto onde vou spawnar as paredes.
            Instantiate(Paredes[Random.Range(0,Paredes.Count)], transform.position, transform.rotation);
            TempoCont = 0f;
        }
        
    }
}
