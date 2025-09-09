using System.Collections;
using UnityEngine;
using TMPro;

public class Count_Down : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public GameObject TimerUI; // Timer UI
    public GameObject ScoreUI; // Coins Score UI
    public GameObject car; // The car object or script to disable/enable movement

    private void Start()
    {
        TimerUI.SetActive(false); // To hide Timer UI when start to count down
        ScoreUI.SetActive(false); // To hide Score UI when start to count down
        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        // Disable car control
        car.GetComponent<Move>().enabled = false;

        int count = 3;
        while (count > 0)
        {
            countdownText.text = count.ToString();
            yield return new WaitForSeconds(1);
            count--;
        }

        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false);

        // Enable car control
        car.GetComponent<Move>().enabled = true;
        TimerUI.SetActive(true); // To Show Timer UI when finish count down
        ScoreUI.SetActive(true); // To Show Score UI when finish count down
    }
}