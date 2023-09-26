using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Select : MonoBehaviour
{
    [Header("# Object ")]
    public GameObject[] characterPrefabs; //  Prefabs 배열
    public Transform[] spawnPoints; // 캐릭터 생성 위치
    public Transform[] EndPoints; // 캐릭터 생성 위치
    public Transform BossPoint; // 캐릭터 생성 위치
    // public List<Vector3> Teleport;
    private GameObject currentCharacter;   // 현재 캐릭
    private Vector3 previousPosition;
    public int Max;
    public int Rand;

    private void Start()
    {
        Max = spawnPoints.Length;
        //Teleport.Add(new Vector3(-36.3f, 8.7f, 0));
        //Teleport.Add(new Vector3(-66.4f, -1.5f, 0));
        //Teleport.Add(new Vector3(-97.4f, -2.8f, 0));
        // 캐릭터 생성
        SpawnCharacter(0);
    }

    private void SpawnCharacter(int characterIndex)
    {

        // 새로운 캐릭터 생성을 위해 캐릭 삭제
        if (currentCharacter != null)
        {
            previousPosition = currentCharacter.transform.position;
            Destroy(currentCharacter);
        }

        // 인트 랜덤 스폰지역
        if (Max > 0)
        {
            int Rand = Random.Range(0, Max);

            //int Dochack = Random.Range(0, Teleport.Count);
            //currentCharacter = Instantiate(characterPrefabs[characterIndex], Teleport[Dochack], Quaternion.identity);
            //Teleport.RemoveAt(Dochack);

            // 현재 캐릭값의 위치를 잡아서, 그 값(previousPosition)으로 생성함 // 변경 스폰포인트
            currentCharacter = Instantiate(characterPrefabs[characterIndex], spawnPoints[Rand].position, Quaternion.identity);
            //    Debug.Log(spawnPoints[Rand]);
            //    Debug.Log(EndPoints[Rand]);
        }
        else
        {
            currentCharacter = Instantiate(characterPrefabs[characterIndex], BossPoint.position, Quaternion.identity);
        }
    }
    //그거 좌표 다른이유 암 그 좌표가 폴더가 밑에 내려오는건 기준 좌표가 위에 좌표에서 좌표가 바뀐거임

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

        // 캐릭 변경
        SpawnCharacter(characterIndex);
    }
}
