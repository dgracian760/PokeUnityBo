using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondPlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10.0f;
    private float HoritzontalInput;
    private float VerticalInput;
    private float sceneBoundZ;
    private float sceneBoundX;

    public Image HealthBar;
    private float Health = 1;
    private HealthBarHandler HealthHandler;

    private void Start()
    {
        sceneBoundX = gameObject.transform.position.x + 3;
        sceneBoundZ = 6;
        HealthHandler = new HealthBarHandler(HealthBar);
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
        VerticalMovement();

        //Test HealthBar
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    HealthHandler.SetHealthBarValue(Health - 0.2f);
        //    Health -= 0.2f;
        //}
    }

    private void HorizontalMovement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < -sceneBoundX)
            {
                transform.position = new Vector3(-sceneBoundX, transform.position.y, transform.position.z);

            }
            else if (transform.position.x > sceneBoundX)
            {
                transform.position = new Vector3(sceneBoundX, transform.position.y, transform.position.z);

            }
            HoritzontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * HoritzontalInput * Time.deltaTime * speed);
        }
    }

    private void VerticalMovement()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
        {
            if (transform.position.z < 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            }
            else if (transform.position.z > sceneBoundZ)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, sceneBoundZ);
            }
            VerticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * speed);
        }
    }
}
