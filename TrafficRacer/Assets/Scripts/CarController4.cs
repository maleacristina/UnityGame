using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController4 : MonoBehaviour
{

    public float carSpeed;
    public float maxPos = 1.70f;

    Vector3 position;
    public UIManager4 ui;
    //public AudioManager am;

    //void Awake()
    //{
    //am.carSound.Play();
    //}

    // Use this for initialization
    void Start()
    {
        //ui = GetComponent<UIManager>();
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -1.75f, 1.75f);
        transform.position = position;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            ui.gameOverActivated();
            //am.carSound.Stop();
        }
    }
}
