using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2.0f;
    public float offet_x = 0;
    public float offet_y = 0;
    void Start() {

    }
    void Update()
    {
        float interpolation = speed * Time.deltaTime;
        Vector3 pos = this.transform.position;

        pos.x = Mathf.Lerp(this.transform.position.x, Player.transform.position.x + offet_x, interpolation);
        pos.y = Mathf.Lerp(this.transform.position.y, Player.transform.position.y + offet_y, interpolation);
        this.transform.position = pos;
    }
}