using UnityEngine;

public class playercoll : MonoBehaviour
{
    public playermovement movement;
    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "Obstacle")
        {
           movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
