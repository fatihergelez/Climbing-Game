using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRagdollController : MonoBehaviour
{
    public GameObject radgollbody;
    public GameObject basicbody;

    


    void Start()
    {
        
    }

      private void OnCollisionEnter(Collision other) {


         if (other.gameObject.tag == "fall")
         {
             
             basicbody.SetActive(false);
             radgollbody.SetActive(true);
             
         }

 } 

    
    void Update()
    {
     
    }
}
