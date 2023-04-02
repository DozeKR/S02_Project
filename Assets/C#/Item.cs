using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ItemData data;
    public int level;
    public Weapon weapon;

    Image icon;
    Text textLevel;

    void Awake(){
        icon = GetComponentsInChildren<Image>()[1];
        icon.sprite = data.itemIcon;

        Text[]texts = GetComponentsInChildren<Text>();
        textLevel = texts[0];
    }

    void LateUpdate() {
        textLevel.text = "LV." + (level + 1);
    }

    public void OnClick(){
        switch(data.itemType){
            case ItemData.ItemType.Melee:
            case ItemData.ItemType.Range:

                break;
            case ItemData.ItemType.Stat:

                break;
            case ItemData.ItemType.Shoe:

                break;
            case ItemData.ItemType.Heal:

                break;
        }

        level++;

        if(level == data.damagees.Length) {
            GetComponent<Button>().interactable = false;
        }
    }
}
