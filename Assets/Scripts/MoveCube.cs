using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    [SerializeField] private float distance = 10;
    [SerializeField] private float speed;

    private Rigidbody rb;

    private void Awake() => rb = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        // Calculate the percentage based on the since of the time elapsed
        var percentage = Mathf.Sin(Time.time / distance * Mathf.PI * 2);

        // Clamp the percentage to be between 0 and 1
        percentage = Mathf.Clamp01(percentage);

        speed = percentage < .5f ? Mathf.Abs(speed) : -Mathf.Abs(speed);
        print(percentage);
        rb.velocity = new Vector3(speed, 0 , 0);

    }

}
