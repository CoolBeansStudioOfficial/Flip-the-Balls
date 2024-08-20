using UnityEngine;

public class player : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") != 0f)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - Input.GetAxis("Mouse X"));

            //quaternions are a slimy son of a gun
        }
    }
}
