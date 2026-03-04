using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    [SerializeField]
    private Vector3 destroyPosition;

    private void LateUpdate()
    {
        if ((destroyPosition - transform.position).sqrMagnitude < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}


/*
 * File : PositionAutioDestroyer.cs
 * Desc
 * : 화면 밖으로 나갈 수 없는 오브젝트에 부착해서 사용
 * : 오브젝트가 일정 범위 바깥으로 나가면 삭제
 * 
 */