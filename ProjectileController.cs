using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController: MonoBehaviour {
    public GameObject projectilePrefab;
    public float speed = 100;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start() {
        }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, player.transform.position, player.transform.rotation);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }

        }

    //If collides with Enemy Destroy Enemy & Projectile. If collides with ground destroy projectile
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Enemy") {
            Destroy(other.gameObject);
            Destroy(projectilePrefab);
        } else if (other.gameObject.name == "Ground") {
            Destroy(projectilePrefab);
        }

    }



}


