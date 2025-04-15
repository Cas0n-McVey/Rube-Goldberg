using UnityEngine;

public class Spinny : MonoBehaviour
{

    public float speed = 25;
    public Vector3 rotationAxis;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, speed * Time.deltaTime); // Rotates object on axis
    }
}
