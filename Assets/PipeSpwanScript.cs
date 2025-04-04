using UnityEngine;


public class pipeSpwanScript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanrate = 2;
    private float timer = 0;
    public float heightOffSet = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0;
        }

    }
    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float heighestPoint = transform.position.y + heightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,heighestPoint),0), transform.rotation);
       
    }

}
