using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
   public Transform player;
   public Text text;
   public float temp;
   // Update is called once per frame
    void Update()
    {
    temp = player.position.z + 13;
       text.text = temp.ToString("0");
    }
}
