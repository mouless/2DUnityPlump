using Assets.Scripts;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject PrefabCard;
    public GameObject HorizontalLayoutGroup;

    public void OnClick()
    {
        GameObject playerCard = Instantiate(PrefabCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(HorizontalLayoutGroup.transform, false);

        gameObject.SetActive(false);

        const int tricksNumba = 5;
        CalculateTricksPerRound(tricksNumba);

        GameService.WhoStartsTheGame = GameService.r.Next(0, 4);

        GameService.StartGame();
    }

    private static void CalculateTricksPerRound(int tricksNumba)
    {
        for (int i = tricksNumba; i > 0; i--)
        {
            if (i == 1)
            {
                for (int x = 1; x < tricksNumba + 1; x++)
                {
                    GameService.TricksPerRound.Push(x);
                }
                continue;
            }
            GameService.TricksPerRound.Push(i);
        }

        // Generate the Tricks per round in the following fashion:
        // 4
        // 3
        // 2
        // 1
        // 2
        // 3
        // 4
    }
}
