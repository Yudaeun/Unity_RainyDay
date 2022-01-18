using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ritsu : MonoBehaviour
{
    float direction = -0.009f;//왼쪽방향
    float toward = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1;
            direction *= -1;
        }
        if(transform.position.x>2.8f) //캐릭터가 2.8f(벽의 위치)에 닿으면
        {
            direction = -0.009f; //오른쪽으로 방향전환
            toward = 1.0f;

        }
        else if (transform.position.x < -2.8f)
        {
            direction = 0.009f; //왼쪽으로 방향전환
            toward = -1.0f;
        }
        //Debug.Log(transform.position.x); //오브젝트의 위치 확인
        transform.position += new Vector3(direction, 0, 0); //위치옮기기
        transform.localScale = new Vector3(toward, 1, 1); //방향전환

    }
}
