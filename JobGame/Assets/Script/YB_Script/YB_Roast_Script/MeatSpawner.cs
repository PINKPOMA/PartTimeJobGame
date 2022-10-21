using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class MeatSpawner : MonoBehaviour
{
    public int meatCount; // 현재 불판에 있는 고기의 개수를 담을 변수입니다.
    [SerializeField] private float maxYPos; // 고기가 생성될 수 있는 위치에서 Y좌표의 최댓값을 담을 변수입니다.
    [SerializeField] private float maxXPos; // 고기가 생성될 수 있는 위치에서 X좌표의 최댓값을 담을 변수입니다.
    [SerializeField] private GameObject meatObject; // 고기 오브젝트입니다.
    [SerializeField] private TextMeshProUGUI meatCountText; // 현재 불판에 있는 고기의 개수를 보여줄 Text입니다.

    public void MeatSpawn() // 버튼에 달아줄 함수입니다. 클릭 시 고기를 불판 위에 생성합니다.
    {
        if (meatCount > 9) return;  // 고기가 10개 이상일 때에는 아래 코드를 실행하지 못하도록 return 해줍니다.
        meatCount++; // 고기의 개수를 올려줍니다.
        RefreshCountText(); // 위에서 고기의 개수를 하나 증가시켰으니 함수를 호출하여 Text를 새로고침 해줍니다.
        Instantiate(meatObject, 
            new Vector2(Random.Range(-maxXPos, maxXPos), Random.Range(-maxYPos, maxYPos)),
            Quaternion.identity); // 고기를 위에서 지정한 위치 안에서 랜덤한 부분에 생성합니다.
    }

    public void RefreshCountText() // 고기의 개수를 보여주는 Text를 새로고침 하는 용도입니다.
    {
        meatCountText.text = $"고기 수: {meatCount}";
    }
}
