using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    int score,type;
    float size;
    
    // Start is called before the first frame update
    void Start()
    {
        float x=Random.Range(-2.7f, 2.7f);
        float y=Random.Range(3.0f, 5.0f);
        transform.position=new Vector3(x, y, 0);
        //랜덤한 위치에서 시작되게 세팅

        type= Random.Range(1, 4); //사이즈를 변경하기 위한 변수 type

        if (type== 1)//가장 큰 크기로 설정
        {
            size= 1.2f;
            score = 3;
            
        }
        else if (type== 2) //중간 크기로 설정
        {
            size= 1.0f;
            score = 2;
           
        }
        else //가장 작은 크기로 설정
        {
            size= 0.8f;
            score = 1;

        }
        transform.localScale = new Vector3(size, size, 0);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground") //태그가 ground이면
        {
            Destroy(gameObject); //
        }
    }
}
