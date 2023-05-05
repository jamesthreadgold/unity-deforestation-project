using UnityEngine;

public class Controller : MonoBehaviour
{

    public bool Drivable = false;

    public float speed = .1f;

    public Vector2 turn;

    // Update is called once per frame
    void Update()
    {
        if (Drivable == true)
        {

            float xDirection = Input.GetAxis("Horizontal");
            float zDirection = Input.GetAxis("Vertical");

            turn.x += Input.GetAxis("Mouse x");
            turn.y += Input.GetAxis("Mouse Y");
            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

            transform.position += moveDirection * speed;
    }
        }
}
