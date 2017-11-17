using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController3 : MonoBehaviour
{

    public float carSpeed;
    public float maxPos = 1.70f;
	public UIManager3 uiManager; 

    Vector3 position;
    public UIManager3 ui;
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
		if ((uiManager.oil+1) % 5 == 0) {
			carSpeed -= 2f; 
		} else 
		{
			carSpeed = 5f; 
		}
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
