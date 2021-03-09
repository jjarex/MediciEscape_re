using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpider : MonoBehaviour
{
    public GameObject spiderObj;
    public float speed;
    NavMeshAgent agent;
    public static EnemySpider instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //StartCoroutine(RandomMove());
        agent = GetComponent<NavMeshAgent>();
        RandomPos();
    }
    void Update()
    {
        speed = agent.speed;
        //print($"{agent.transform.position},{agent.destination}");
        float dist = Vector3.Distance(transform.position, agent.destination);
        if (dist <= 2)
             RandomPos();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spiderObj.GetComponent<EnemySpiderObj>().trap = true;
            //spiderObj.gameObject.GetComponent<Rigidbody>().useGravity = true;
            //gameObject.GetComponent<EnemySpider>.enabled = false;
            //spiderObj.transform.position += Vector3.down * dropSpeed * Time.deltaTime;

        }
    }
    IEnumerator  RandomPosi()
    {
        float y = transform.position.y;

        float xx = Random.Range(-70, 60);
        float zz = Random.Range(-30, 30);

        Vector3 dir = new Vector3(xx, y, zz);
        agent.destination = dir;
        yield return new WaitForSeconds(2);
    }
    IEnumerator RandomMove()
    {

        float xx = Random.Range(-1, 1);
        float zz = Random.Range(-1, 1);

        float x = transform.position.x + xx;
        float y = transform.position.y;
        float z = transform.position.z + zz;
        float xxx = Mathf.Clamp(0, -70, 60);
        float zzz = Mathf.Clamp(0, -30, 30);
        Vector3 dir = new Vector3(xxx, y, zzz);

        agent.destination = dir;
        //transform.position = dir;

        yield return null;

    }
    void RandomPos()
    {
        float y = transform.position.y;

        float xx = Random.Range(-70, 60);
        float zz = Random.Range(-30, 30);

        Vector3 point = new Vector3(xx, y, zz);
        agent.destination = point;
    }
}
