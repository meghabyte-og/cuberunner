using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playercontroller : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Ground")
        {
            canJump=true;
        }
    }
    
    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag=="Ground")
        {
            canJump=false;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Obstacle")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
