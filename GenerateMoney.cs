using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMoney : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    public int waiteSecond;
    public int minX;



    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(waiteSecond);
        Vector2 pos = spawnPos.position + new Vector3(Random.Range(minX, range.x), Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
