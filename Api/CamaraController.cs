using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        //�������
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
    }
}
