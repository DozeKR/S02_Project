using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public Vector2 inputVec;    
    public float speed;

    Rigidbody2D rigid;

    void Start(){
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        Vector2 nextVec =inputVec.normalize * speed *
    }

}
