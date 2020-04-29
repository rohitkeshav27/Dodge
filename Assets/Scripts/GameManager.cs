using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool hasended = false;
    public float redelay = 2f;
    public GameObject completelevel;

    public void Ending()
    {
        completelevel.SetActive(true);
    }
   public void EndGame()
    {
        if (hasended == false)
        {
            hasended = true;
            Debug.Log("Game Over");
            Invoke("Restart", redelay);
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
