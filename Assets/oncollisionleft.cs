using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oncollisionleft : MonoBehaviour
{
    // Start is called before the first frame update

    public Text t;
   public static int left = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.name == "Hit")
        {
            Debug.Log(c.collider.name);
            t.text = "Score : " + (++left).ToString();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
