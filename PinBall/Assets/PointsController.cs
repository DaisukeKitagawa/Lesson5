using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour
{
    private int SmallStarPoints = 10;
    private int LargeStarPoints = 20;
    private int SmallCloudPoints = 30;
    private int LargeCloudPoints = 40;

    int totalPoints = 0;

    private GameObject PointsText;

    // Start is called before the first frame update
    void Start()
    {
            
        this.PointsText = GameObject.Find("PointsText");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.totalPoints += SmallStarPoints;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.totalPoints += LargeStarPoints;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.totalPoints += SmallCloudPoints;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.totalPoints += LargeCloudPoints;
        }
        Debug.Log(totalPoints);
        this.PointsText.GetComponent<Text>().text = "Score:" + totalPoints;
    }
}
