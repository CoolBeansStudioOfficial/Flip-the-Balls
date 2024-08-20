using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool isLeft;
    void OnTriggerEnter(Collider collider)
    {
        if (isLeft)
        {
            print("hit left");
        }
        else
        {
            print("hit right");
        }
    }
}
