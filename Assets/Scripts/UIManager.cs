using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    [SerializeField] private GameObject ShowCoinText;
    [SerializeField] private Transform ShowPointsPlace;

    [SerializeField] private float mTime = 0.5f;
    private float cTime;

    private int points = 0;


    void Start()
    {

    }

    void Update()
    {
        PointUp();
        UpdateUI();
    }


    public void CoinUp(int point)
    {
        points += point;

        GameObject showText = Instantiate(ShowCoinText, ShowPointsPlace.position, Quaternion.identity, ShowPointsPlace);
        showText.GetComponent<Text>().text = point.ToString();
    }

    private void PointUp()
    {
        cTime += Time.deltaTime;

        if (cTime >= mTime)
        {
            points++;

            cTime = 0;
        }
    }

    public void UpdateUI()
    {
        pointsText.text = $"Очки: {points.ToString()}";
    }

}
