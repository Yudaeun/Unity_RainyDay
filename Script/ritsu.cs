using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ritsu : MonoBehaviour
{
    float direction = -0.009f;//���ʹ���
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
        if(transform.position.x>2.8f) //ĳ���Ͱ� 2.8f(���� ��ġ)�� ������
        {
            direction = -0.009f; //���������� ������ȯ
            toward = 1.0f;

        }
        else if (transform.position.x < -2.8f)
        {
            direction = 0.009f; //�������� ������ȯ
            toward = -1.0f;
        }
        //Debug.Log(transform.position.x); //������Ʈ�� ��ġ Ȯ��
        transform.position += new Vector3(direction, 0, 0); //��ġ�ű��
        transform.localScale = new Vector3(toward, 1, 1); //������ȯ

    }
}
