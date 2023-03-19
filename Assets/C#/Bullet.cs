using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 데미지
    public float damage;
    // 관통력
    public int per;

    public void Init(float damage, int per){
        this.damage = damage;
        this.per = per;
    }
}
