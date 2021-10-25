using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_tile;

    [SerializeField] private Vector2 m_initialPosition;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnTile()
    {
        Debug.Log("instance");
        int index = Random.Range(0, m_tile.Count);

        Instantiate(m_tile[index], m_initialPosition, m_tile[index].transform.rotation);
        m_tile[index].GetComponent<TileCtrl>().m_tileManager = this;
    }
}
