
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public float speedMul = 1f;
    public GameObject kirbyPrefab; 


    // Update is called once per frame
    void Update()
    {
        /*Vector3 pos = transform.position;

        if (Input.GetKey("w")) 
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s")) 
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d")) 
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a")) 
        {
            pos.x -= speed * Time.deltaTime;
        }
         if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnKirby();
        }
    

        transform.position = pos; */

        float xPos = Input.GetAxis("Horizontal");
        float speed = Time.deltaTime * speedMul * xPos;
    



    }
            public void SpawnKirby()
    {
        GameObject kirby = Instantiate(kirbyPrefab, Vector3.zero, Quaternion.identity);

    }
    

}
