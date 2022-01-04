using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    float offsetX;
    float offSetY;
    // Start is called before the first frame update
    void Start()
    {
        offsetX = this.transform.position.x - player.position.x;
        offSetY = this.transform.position.y-player.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = new Vector3(player.position.x+offsetX, player.position.y + offSetY, this.transform.position.z);
    }
}
