using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    Vector3 distance;
    
    void Start()
    {
        distance = transform.position - player.transform.position;
    }

    private void Update() {
        transform.position = player.transform.position + distance;
    }

    private void LateUpdate() {
        transform.position = player.transform.position + distance;
    }
    
}
