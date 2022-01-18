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
        //������ ��ġ���� ���۵ǰ� ����

        type= Random.Range(1, 4); //����� �����ϱ� ���� ���� type

        if (type== 1)//���� ū ũ��� ����
        {
            size= 1.2f;
            score = 3;
            
        }
        else if (type== 2) //�߰� ũ��� ����
        {
            size= 1.0f;
            score = 2;
           
        }
        else //���� ���� ũ��� ����
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
        if (coll.gameObject.tag == "ground") //�±װ� ground�̸�
        {
            Destroy(gameObject); //
        }
    }
}
