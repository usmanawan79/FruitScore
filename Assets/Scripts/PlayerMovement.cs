using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    float speed = 3.0f;
    public GameObject[] fruits;
    public Text txt;
    int s=0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Randomizer",1.0f,5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal,0,vertical ) * (speed * Time.deltaTime));
        
        
    }

    void Randomizer()
    {
        Vector3 Rendomizer = new Vector3(Random.Range(-4,5),0,Random.Range(-4,4));
        int rand=Random.Range(0,3);
        Instantiate(fruits[rand],Rendomizer,Quaternion.identity);
    }
    private void OnCollisionEnter(Collision other) {
        
    }
    private void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag=="green")
        {
            s+=5;
            txt.text=s.ToString();
            Destroy(other.gameObject);
        }
    }

}
