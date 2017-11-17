using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float carSpeed;
    public float maxPosition = 1.7f;
   public UIManager uiManager; 
    Vector3 position;
    public UIManager ui;
    public AudioManager am;

    void Awake()
    {
        am.carSound.Play();
    }

	// Use this for initialization
	void Start () {
        //ui = GetComponent<UIManager>();
       position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (ui.bananas == 20) 
		{
			ui.bananas = 0; 
			carSpeed += 20; 
            
		}
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x= Mathf.Clamp(position.x, -1.92f, 1.50f);
        transform.position = position;
	}
 
}
