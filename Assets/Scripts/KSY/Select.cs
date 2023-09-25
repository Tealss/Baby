using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    [Header("# Object ")]
    public GameObject[] characterPrefabs; //  Prefabs �迭
    public Transform[] spawnPoints; // ĳ���� ���� ��ġ
    private GameObject currentCharacter;   // ���� ĳ��
    private Vector3 previousPosition;
    

    private void Start()
    {
        // ĳ���� ����
        SpawnCharacter(0);

    }

    private void SpawnCharacter(int characterIndex)
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        // ���ο� ĳ���� ������ ���� ĳ�� ����
        if (currentCharacter != null)
        {
            previousPosition = currentCharacter.transform.position;
            Destroy(currentCharacter);
        }

        // ���� ĳ������ ��ġ�� ��Ƽ�, �� ��(previousPosition)���� ������
        currentCharacter = Instantiate(characterPrefabs[characterIndex], spawnPoints[randomIndex].position, Quaternion.identity);
    }

    public void ChangeCharacter(int characterIndex)
    {

        // ĳ�� ����
        SpawnCharacter(characterIndex);
    }
}
