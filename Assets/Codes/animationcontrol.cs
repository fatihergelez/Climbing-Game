using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrol : MonoBehaviour
{

    Animator animator;
    RaycastHit touchedobject;
    Camera cam;
     public GameObject gameoverpanel;
      public GameObject successpanel;
      public GameObject finalposition;
      public GameObject basicbody;
      public AudioSource succesvoice;
      
    void Start()
    {
        animator = GetComponent<Animator>();
    }

 void OnCollisionEnter(Collision other) {
       if (other.gameObject.tag == "final")
         {
                    succesvoice.Play();
                    basicbody.transform.position = finalposition.transform.position;
                    animator.SetBool("final",true);
                    successpanel.SetActive(true);                 
         }
   }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            animator.SetBool("jump", true);         
        }
        else
        {
            animator.SetBool("jump", false);
        }
    }
}
