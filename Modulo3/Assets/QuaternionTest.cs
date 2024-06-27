using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTest : MonoBehaviour
{
    public Transform target;
    public Transform anoterObject;
    public float TempoRotation = 5f;

    // Update is called once per frame
    private void Start()
    {
    }
    private void Update()
    {
        //utilizado para rotacionar um elemento target na mesma rotação que outro elemento
        transform.rotation = Quaternion.Slerp(target.rotation, anoterObject.rotation, TempoRotation);
        TempoRotation = TempoRotation + Time.deltaTime;
        //Usado para rotacionar um objeto em determinada rotação
        //transform.rotation = Quaternion.Euler(1, 1, 1);
    }
}
