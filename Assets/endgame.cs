using UnityEngine;

public class endgame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameman;
    void OnTriggerEnter()
    {
        gameman.Ending();
    }
}
