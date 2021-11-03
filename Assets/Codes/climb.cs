using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class climb : MonoBehaviour
{
   public GameObject hiddenstone;
   Rigidbody rigidbodbasic;

   public GameObject firscamera;
   public GameObject secondcamera;
   Camera cam;
   public GameObject radgollbody;
   public GameObject basicbody;
   public float speeed = 1f;
   private bool touchedpoint;
   RaycastHit touchedobject;
   Animator animator;
   public AudioSource gamevoice;
   public AudioSource jumpvoice;
   public AudioSource fallvoice;
   public AudioSource succesvoice;
   public GameObject gameoverpanel;
   
   
    void Start()
    {
       rigidbodbasic = GetComponent<Rigidbody>();

       cam = GameObject.Find("Main Camera").GetComponent<Camera>();  

       touchedpoint = false; 
       
    }

    /*void FixedUpdate() {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("TouchedMouseScreen");
            RaycastHit touchedobject2;
            Touch mouse = Input.GetTouch(0);
            if (Physics.Raycast(cam.ScreenPointToRay(mouse.position), out touchedobject2))
            {
                if (touchedobject2.collider.gameObject.tag == "stones")
                {
                    hiddenstone.transform.position  = Vector3.MoveTowards(transform.position,touchedobject2.transform.position ,.4f);
                }
                if (touchedobject2.collider.gameObject.tag != "stones")
                {
                     basicbody.SetActive(false);
                     radgollbody.SetActive(true);
                }
            }
        }
    }  */
 void OnCollisionEnter(Collision other) {


         if (other.gameObject.tag =="stones")
         {
             Debug.Log("TouchedStone");
                      
                      
         }  

         if (other.gameObject.tag =="tramp")
         {
             fallvoice.Play();
             basicbody.SetActive(false);
             radgollbody.SetActive(true);
             firscamera.SetActive(false);
             secondcamera.SetActive(true);
             gameoverpanel.SetActive(true);
         }
         
        
             
 } 
    void Update()
    {  
      
        
        if (Input.touchCount > 0)
        {
            jumpvoice.Play();
            
            Debug.Log("touched");
            Touch finger = Input.GetTouch(0);
            
            if (Physics.Raycast(cam.ScreenPointToRay(finger.position), out touchedobject))
            {
                if (touchedobject.collider.gameObject.tag == "stones")
                {
                       
                     touchedpoint = true;

                }
                if (touchedobject.collider.gameObject.tag == "fallstone")
                {
                    fallvoice.Play();
                    hiddenstone.transform.position  = Vector3.MoveTowards(transform.position,touchedobject.transform.position ,.3f);  
                    basicbody.SetActive(false);
                    radgollbody.SetActive(true);
                    firscamera.SetActive(false);
                    secondcamera.SetActive(true);
                }
                
              
            }



        }
        if (touchedpoint == true)
        {
            hiddenstone.transform.position  = Vector3.MoveTowards(hiddenstone.transform.position,touchedobject.transform.position , .5f);
            if (hiddenstone.transform.position == touchedobject.transform.position)
            {
                touchedpoint = false;
                cam.transform.Translate(0,1.5f,0);
            }
        }
       
    }
    
}

