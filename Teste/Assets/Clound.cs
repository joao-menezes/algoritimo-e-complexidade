using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clound : MonoBehaviour
{
public Transform target;//set target from inspector instead of looking in Update
public float speed = 3f;
private Transform myTransform;


void Start()
{
    myTransform = this.GetComponent<Transform>();

}

void Update()
{

    //coloca para a posicao do alvo
    transform.LookAt(target.position);
    transform.Rotate(new Vector3(0, -90, 0), Space.Self);//coloca na posicao original



        myTransform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);



}
}