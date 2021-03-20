using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionChangeScene : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {        if(collision.gameObject.tag == "Object2")
        {
            SceneManager.LoadScene("SecondaryScene");
        }        
    }
}
