using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool onGround;
    public float fuerza_x;
    // Start is called before the first frame update
    void Start()
    {
       onGround = false; 
       fuerza_x=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
        print("Space key was released");
      if (GetComponent<Rigidbody>() != null)
      {
        GetComponent<Rigidbody>().useGravity = true;
      }
        }
      if(Input.GetKeyDown(KeyCode.A))
      {
      if (onGround){
        Vector3 fuerza = new Vector3(fuerza_x, 600, -500);
        GetComponent<Rigidbody>().AddForce(fuerza);
      }
    }
     if(Input.GetKeyDown(KeyCode.Z))
      {
        fuerza_x = fuerza_x - 10;
      }
       if(Input.GetKeyDown(KeyCode.X))
      {
        fuerza_x = fuerza_x + 10;
      }
    }
    private void OnCollisionEnter(Collision c){
        Debug.Log("colision");
        onGround = true;
    }
      private void OnCollisionStay(Collision c){
        onGround = true;
    }
      private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
    }
}
