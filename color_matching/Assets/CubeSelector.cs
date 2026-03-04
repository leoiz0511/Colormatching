using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    private ObjectDetector objectDetector;

    private void Awake()
    {
        objectDetector = GetComponent<ObjectDetector>();

        // 레이어가 "Touchable" 인 오브젝트면 선택 가능하도록 ObjectDetector의 layerMask 설정
        // ObjectDetector 클래스의 raycastEvent.Invoke(hit.transform); 가 호출될 때 SelectCube 호출

        objectDetector.raycastEvent.AddListener(SelectCube);
    }

    public void SelectCube(Transform hit)
    {
        // 선택된 오브젝트의 CubeController.ChangeColor()를 호출해 큐브 색상 변경
        hit.GetComponent<CubeController>().ChangeColor();
    }
}
