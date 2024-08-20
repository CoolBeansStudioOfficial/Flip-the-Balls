using UnityEngine;

public class ball : MonoBehaviour
{
    public bool isRed;

    void OnTriggerEnter(Collider collider)
    {
        if (isRed && collider.gameObject.name == "Trigger Left")
        {
            GameObject.Find("Game Manager").GetComponent<gameManager>().UpdateScore(1);
        }
        else if (!isRed && collider.gameObject.name == "Trigger Right")
        {
            GameObject.Find("Game Manager").GetComponent<gameManager>().UpdateScore(1);
        }
        else
        {
            GameObject.Find("Game Manager").GetComponent<gameManager>().UpdateScore(-1);
        }
    }

    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
    }
}
