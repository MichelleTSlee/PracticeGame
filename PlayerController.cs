using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody playerRb;
    private float speed = 500;
    private GameObject focalPoint;

   void Start() {
       playerRb = GetComponent<Rigidbody>();
       focalPoint = GameObject.Find("Focal Point");
    }

    void Update() {
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);

        }

    }

    


    