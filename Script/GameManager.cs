using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sena_rain;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 1.0f); //0.5�ʸ��� �ݺ������� ����.
    }

    // Update is called once per frame
    void Update()
    {
    }
    void makeRain()
    {
        Instantiate(sena_rain);//������ ����Ǵ� ���߿� ������Ʈ ����
    }
}
