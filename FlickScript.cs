using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickScript : MonoBehaviour
{
    [SerializeField] GameObject Player;
    Vector3 startTouchPos;
    Vector3 endTouchPos;

    float flickValue_x;
    float flickValue_y;

    Rigidbody player_rb;

    [SerializeField] float jumpPower = 10.0f;

    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Player.transform.position = new Vector3(Mathf.Clamp(Player.transform.position.x, -1, 1), Player.transform.position.y, Player.transform.position.z);

        if (Input.GetMouseButtonDown(0) == true)
        {
            startTouchPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            endTouchPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            FlickDirection();
            GetDirection();
        }
    }

    void FlickDirection()
    {
        flickValue_x = endTouchPos.x - startTouchPos.x;
        flickValue_y = endTouchPos.y - startTouchPos.y;
        //Debug.Log("x �X���C�v�ʂ�" + flickValue_x);
        //Debug.Log("y �X���C�v�ʂ�" + flickValue_y);
    }

    void GetDirection()
    {
        //�E�Ƀt���b�N
        if (flickValue_x > 500.0f)
        {
            transform.position += new Vector3(1, 0, 0);
        }

        //���Ƀt���b�N
        if (flickValue_x < -500.0f)
        {
            transform.position -= new Vector3(1, 0, 0);
        }

        if (flickValue_y > 500.0f)
        {
            player_rb.velocity += new Vector3(0, jumpPower, 0);
        }
    }
}
