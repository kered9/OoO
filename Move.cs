using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Move : MonoBehaviour {
    public float jumpPower;
    public float speed;
    public GameObject particleSys;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            this.GetComponent<Rigidbody>().velocity = Vector3.up * jumpPower;
          
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed);
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "collect")
        {
            GameObject obj = Instantiate(particleSys, transform.position, new Quaternion(transform.rotation.x, transform.rotation.y, 
                transform.rotation.z, transform.rotation.w)) as GameObject;

            col.gameObject.SetActive(false);
        }
    }
}
