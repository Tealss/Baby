using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public player player;
<<<<<<< HEAD
    
=======

    [SerializeField] private Transform spawnPositionsRoot;
    private List<Transform> spawnPostions = new List<Transform>();
    public List<GameObject> rewards = new List<GameObject>();

    [SerializeField] private GameObject EndPannel;
>>>>>>> SJM_New2

    void Awake()
    {
        instance = this;

        for (int i = 0; i < spawnPositionsRoot.childCount; i++)
        {
            spawnPostions.Add(spawnPositionsRoot.GetChild(i));
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
<<<<<<< HEAD
=======
    void CreateReward()
    {
        int idx = UnityEngine.Random.Range(0, rewards.Count);
        int posIdx = UnityEngine.Random.Range(0, spawnPostions.Count);

        GameObject obj = rewards[idx];
        Instantiate(obj, spawnPostions[posIdx].position, Quaternion.identity);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoMenu()
    {
        //문자열 대체 필요해 보임.
        SceneManager.LoadScene("StartScene");
    }
>>>>>>> SJM_New2
}
