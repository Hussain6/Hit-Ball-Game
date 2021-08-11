using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Footballmovement : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform t;
    public Transform hit;
    public Rigidbody r;
    public Text rightside;
    public Text leftside;
    public int forwardspeed=50;
    public int leftspeed = 50;
    void Start()
    {

        rightside.text = "Score : " + (oNCOLLISION.right).ToString();
        leftside.text = "Score : " + (oncollisionleft.left).ToString();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("w"))
        {
             r.AddForce(0,0,forwardspeed);
           // transform.Translate(0, 0, 1);
        }
        if (Input.GetKey("s"))
        {
            r.AddForce(0, 0, -forwardspeed);
         //   transform.Translate(0, 0, -1);
        }
        if (Input.GetKey("d"))
        {
          //  transform.Translate(1, 0, 0);
            r.AddForce(leftspeed, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            r.AddForce(-leftspeed, 0,0);
          //  transform.Translate(-1, 0, 0);
        }
        if (t.position.y < -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (hit.position.y < -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
