using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Select : MonoBehaviour
{
    [Header("# Object ")]
    public GameObject[] characterPrefabs; //  Prefabs �迭
    public Transform[] spawnPoints; // ĳ���� ���� ��ġ
    public Transform[] EndPoints; // ĳ���� ���� ��ġ
    public Transform BossPoint; // ĳ���� ���� ��ġ
    // public List<Vector3> Teleport;
    private GameObject currentCharacter;   // ���� ĳ��
    private Vector3 previousPosition;
    public int Max;
    public int Rand;

    private void Start()
    {
        Max = spawnPoints.Length;
        //Teleport.Add(new Vector3(-36.3f, 8.7f, 0));
        //Teleport.Add(new Vector3(-66.4f, -1.5f, 0));
        //Teleport.Add(new Vector3(-97.4f, -2.8f, 0));
        // ĳ���� ����
        SpawnCharacter(0);
    }

    private void SpawnCharacter(int characterIndex)
    {

        // ���ο� ĳ���� ������ ���� ĳ�� ����
        if (currentCharacter != null)
        {
            previousPosition = currentCharacter.transform.position;
            Destroy(currentCharacter);
        }

        // ��Ʈ ���� ��������
        if (Max > 0)
        {
            int Rand = Random.Range(0, Max);

            //int Dochack = Random.Range(0, Teleport.Count);
            //currentCharacter = Instantiate(characterPrefabs[characterIndex], Teleport[Dochack], Quaternion.identity);
            //Teleport.RemoveAt(Dochack);

            // ���� ĳ������ ��ġ�� ��Ƽ�, �� ��(previousPosition)���� ������ // ���� ��������Ʈ
            currentCharacter = Instantiate(characterPrefabs[characterIndex], spawnPoints[Rand].position, Quaternion.identity);
            //    Debug.Log(spawnPoints[Rand]);
            //    Debug.Log(EndPoints[Rand]);
        }
        else
        {
            currentCharacter = Instantiate(characterPrefabs[characterIndex], BossPoint.position, Quaternion.identity);
        }
    }
    //�װ� ��ǥ �ٸ����� �� �� ��ǥ�� ������ �ؿ� �������°� ���� ��ǥ�� ���� ��ǥ���� ��ǥ�� �ٲ����

    public void Update()
    {
        Transform My = currentCharacter.transform;
        float Distance = Vector3.Distance(My.position, EndPoints[Rand].position);
        Debug.Log(Distance);
        if (Distance <= 1)
        {
            Max = Max - 1;
            spawnPoints[Rand] = spawnPoints[Max];
            EndPoints[Rand] = EndPoints[Max];
            SpawnCharacter(0);
        }
    }
    public void ChangeCharacter(int characterIndex)
    {

        // ĳ�� ����
        SpawnCharacter(characterIndex);
    }
}
