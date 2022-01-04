using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float limitUp;
    public float limitDown;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            body.AddForce(new Vector2(0,-1));
            ShadowSelfs.shadowing = true;
        }
        else
        {
            ShadowSelfs.shadowing = false;
        }
        if(this.transform.position.y > limitUp)
        {
            this.transform.position = new Vector3(transform.position.x, limitDown, transform.position.z);
        }
        else if(this.transform.position.y < limitDown)
        {
            this.transform.position = new Vector3(transform.position.x, limitUp, transform.position.z);
        }
    }
}
