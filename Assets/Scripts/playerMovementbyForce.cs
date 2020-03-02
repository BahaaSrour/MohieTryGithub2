using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementbyForce : MonoBehaviour
{

    #region oldstuff
    //Rigidbody rb ;
    //Vector3 Dircetion = Vector3.zero;
    //[SerializeField] float speed;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = this.GetComponent<Rigidbody>();
    //    if (rb == null)
    //    {
    //        rb = this.gameObject.AddComponent<Rigidbody>();

    //    }
    //    speed = 5f;
    //}

    //// Update is called once per frame
    //void FixedUpdate()
    //{
    //    Dircetion.x = Input.GetAxisRaw("Horizontal");
    //    Dircetion.z = Input.GetAxisRaw("Vertical");
    //    Vector3 dir = Dircetion.normalized;
    //    //this.rb.velocity = Dircetion * speed;
    //    rb.MovePosition(this.transform.position + dir * speed * Time.deltaTime);
    //    //rb.velocity = this.rb.velocity+dir * speed * Time.deltaTime;
    //}

    #endregion



    [SerializeField] Rigidbody rb;
    [SerializeField] float ForwardForce = 2000f;
    [SerializeField] float SidedForce = 500f;


    void Start()
    {

    }

    //void FixedUpdate()
    //{
    //    Dircetion = Vector3.zero;
    //    rb.AddForce(0, 0, ForwardForce);


    //    if (Input.GetAxisRaw("Horizontal") > 0)
    //    {
    //        Dircetion.x += 500; 
    //    } 
    //   else if (Input.GetAxisRaw("Horizontal") < 0)
    //    {
    //        Dircetion.x -= 500; 
    //    }
    //    else 
    //        Dircetion.x =0;  
    //    if (Input.GetAxisRaw("Vertical") > 0)
    //    {
    //        Dircetion.z += 500; 
    //    } 
    //   else if (Input.GetAxisRaw("Vertical") < 0)
    //    {
    //        Dircetion.z -= 500; 
    //    }
    //    else 
    //        Dircetion.z =0; 



    //    rb.AddForce(Dircetion* Time.deltaTime);
    //}

    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);


        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(SidedForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-SidedForce * Time.deltaTime, 0, 0);
        }

    }
}
