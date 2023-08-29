using UnityEngine;

public class GameSettings : MonoBehaviour
{
    //���ӽ������ڸ��� �Ʒ��� �Լ��� ȣ�����ش�.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {

        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = "GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}