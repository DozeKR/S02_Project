using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolmanger : MonoBehaviour
{
    // 프리팹 변수
    public GameObject[] prefabs;
    // 풀 리스트들
    List<GameObject>[] pools;

    void Awake(){
        pools = new List<GameObject>[prefabs.Length];

        for(int i = 0; i < pools.Length; i++){
            pools[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int i){
        GameObject choice = null;

        // 선택한 풀의 비활성화 된 게임 오브젝트 접근
        foreach(GameObject item in pools[i]){
            // 발견시 choice 변수에 할당
            if(!item.activeSelf){
                choice = item;
                choice.SetActive(true);
                break;
            }
        }
        // 미발견시
        if(choice == null){
            // 새롭게 생성해서 choice 변수에 할당
            choice = Instantiate(prefabs[i], transform);
            pools[i].Add(choice); 
        }
            
        return choice;
    }
}
