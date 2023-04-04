using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public ItemData.ItemType type;
    public float rate;

    public void Init(ItemData data){

        //Basic Set
        name = "Gear" + data.itemId;
        transform.parent = GameManager.instance.player.transform;
        transform.localPosition = Vector3.zero;

        //Property Set
        type = data.itemType;
        rate = data.damagees[0];
        ApplyGear();
    }

    public void LevelUp(float rate){
        this.rate = rate;
        ApplyGear();
    }

    //관리
    void ApplyGear(){
        switch(type){
            case ItemData.ItemType.Stat:
                RateUp();
                break;   
            case ItemData.ItemType.Shoe:
                SpeedUp();
                break;
        }
    }

    //공격 속도
    void RateUp(){
        Weapon[] weapons = transform.parent.GetComponentsInChildren<Weapon>();

        foreach(Weapon weapon in weapons){
            switch(weapon.id){
                case 0:
                    weapon.speed = 150 + (150 * rate);
                    break;
                default:
                    weapon.speed = 0.5f * (1f - rate);
                    break;
            }
        }
    }

    //이동 속도
    void SpeedUp(){
        float speed = 3;
        GameManager.instance.player.speed = speed + speed * rate;
    }
}
