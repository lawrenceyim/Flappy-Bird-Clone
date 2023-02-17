using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private PauseMenuToggle pauseMenuToggle;
    private WinMenuToggle winMenuToggle;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        pauseMenuToggle = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<PauseMenuToggle>();
        winMenuToggle = GameObject.FindGameObjectWithTag("WinMenu").GetComponent<WinMenuToggle>();
        if (pauseMenuToggle == null) {
            Debug.Log("Cant find pause");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.localPosition.x + 3 * Time.deltaTime, transform.localPosition.y, transform.localPosition.z);
        if (Input.GetKeyDown("space")) {
            rigidbody2D.velocity = new Vector2(0f, 0f);
            rigidbody2D.AddForce(new Vector2(0f, 200f));
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Obstacle")) {
            pauseMenuToggle.LostGame();
        }
        if (other.gameObject.CompareTag("EndZone")) {
            winMenuToggle.GameWon();
        }
        if (other.gameObject.CompareTag("OutOfBounds")) {
            pauseMenuToggle.LostGame();
        }
    }
}
