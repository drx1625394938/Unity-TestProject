using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BombController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //�����Ӻ���ñ�ը����
        Invoke("Bang", 2);
    }
    void Bang() 
    {
        //������enemy�������������
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        //����enemy
        foreach (GameObject enemy in enemys) 
        {
            //���enemy��ը��֮��ľ���С��3
            if (Vector3.Distance(transform.position, enemy.transform.position) < 3) 
            {
                //�ݻ�enemy����
                Destroy(enemy);
            }
        }
        //����ը��
        Destroy(gameObject);
    }
}
