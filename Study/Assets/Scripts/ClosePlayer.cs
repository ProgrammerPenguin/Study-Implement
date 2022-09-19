using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePlayer : MonoBehaviour
{
    public GameManager _gameManager;
    
    private void Update()
    {
        FindCloseEnemy();
    }

    private void FindCloseEnemy()
    {
        for (int i = 0; i < 5000; ++i)
        {
            Debug.Log("Çï·Î");
            Vector3 enemypositon = _gameManager.list[i];
            float distance = Vector3.Distance(transform.position, enemypositon);
            if(distance < 5)
            {
                Material color = _gameManager.list2[i].GetComponent<MeshRenderer>().material;
                Color red = Color.red;
                color.color = red;
                Debug.Log("µé¾î¿È");
            }
            
        }
    }
}
