using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptParede : MonoBehaviour
{
    public float velocidade;
    void Start()
    {
        Destroy(gameObject,5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1f, 0, 0) * velocidade * Time.deltaTime);
    }
}
