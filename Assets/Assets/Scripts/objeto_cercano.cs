using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto_cercano : MonoBehaviour
{
    public float speed = 30.0f;
    public float radius = 5f;
    public float angle = 0f;
    private Vector3 centerPoint;
    // Start is called before the first frame update
    void Start()
    {
        centerPoint = transform.position + transform.right * radius;
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        if (angle >= Mathf.PI / 2f)
        {
            Destroy(this.gameObject);
        }

        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        transform.position = centerPoint + new Vector3(-x, 0f, z);
    }
}
