using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sena_rain;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 1.0f); //0.5초마다 반복적으로 찍어낸다.
    }

    // Update is called once per frame
    void Update()
    {
    }
    void makeRain()
    {
        Instantiate(sena_rain);//게임이 실행되는 도중에 오브젝트 생성
    }
}
