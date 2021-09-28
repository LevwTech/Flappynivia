using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI scoretext;

    Rigidbody2D bird;

    int score = 0;

    bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        bird = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            bird.velocity = new Vector2(0, 8.5f);
        }
        if(Input.GetKeyDown("r"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D()
    {
        dead = true;
   

    }

    void OnTriggerExit2D(Collider2D col)

    {
        if(col.gameObject.tag == "pointtrigger")
        {
            score++;
            scoretext.text = score.ToString();
        }
        if (col.gameObject.tag == "restart")
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }
}


