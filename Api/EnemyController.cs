using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //��ȡ��Ҷ���
        GameObject Player = GameObject.FindWithTag("Player");
        if (Vector3.Distance(transform.position, Player.transform.position) < 3) //����������Ҿ���С��3
        {
           //��ȡ�����Ե��˵ķ���
            Vector3 dir = Player.transform.position - transform.position;
            //����ת��
            transform.rotation = Quaternion.LookRotation(dir);
            //��������ҷ��򿿽�
            transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        }
    }
}
