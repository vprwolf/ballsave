using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    int type;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 4);

        if (type == 1)
        {
            size = 1.2f;
            GetComponent<SpriteRenderer>().color = new Color(200 / 255f, 0 / 255f, 0 / 255f, 255 / 255f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            GetComponent<SpriteRenderer>().color = new Color(200 / 255f, 9 / 255f, 9 / 255f, 255 / 255f);
        }
        else
        {
            size = 0.8f;
            GetComponent<SpriteRenderer>().color = new Color(200 / 255f, 0 / 255f, 0 / 255f, 255 / 255f);
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ball")
        {
            gameManager.I.gameOver();
        }
    }
}
