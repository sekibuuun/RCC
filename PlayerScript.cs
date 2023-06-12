using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    [SerializeField] GameObject Player3;
    [SerializeField] GameObject Player4;

    GameObject scoreObject;
    GameObject lifeObject1;
    GameObject lifeObject2;
    GameObject lifeObject3;

    [SerializeField] int up_Level2;
    [SerializeField] int up_Level3;
    [SerializeField] int up_Level4;

    public ScoreScript scoreComp;

    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("TotalScore");
        lifeObject1 = GameObject.Find("Life1");
        lifeObject2 = GameObject.Find("Life2");
        lifeObject3 = GameObject.Find("Life3");

        Player1.SetActive(true);
        Player2.SetActive(false);
        Player3.SetActive(false);
        Player4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (up_Level2 <= scoreComp.score)
        {          
            Player1.SetActive(false);
            Player2.SetActive(true);
        }

        if (up_Level3 <= scoreComp.score)
        {
            Player2.SetActive(false);
            Player3.SetActive(true);
        }

        if (up_Level4 <= scoreComp.score)
        {
            Player3.SetActive(false);
            Player4.SetActive(true);
        }

    }

//    void OnCollisionEnter(Collision col)
//    {   
//        if (col.gameObject.tag == "100dol")
//        {
//            scoreObject.GetComponent<ScoreScript>().Dol_100();
//        }
//        if (col.gameObject.tag == "1000dol")
//        {
//            scoreObject.GetComponent<ScoreScript>().Dol_1000();
//        }
//        if (col.gameObject.tag == "Barrier")
//        {
//            if(lifeObject3 != null)
//            {
//                lifeObject3.GetComponent<LifeScript>().Break();
//            }
//            else
//            {
//                if (lifeObject2 != null)
//                {
//                    lifeObject2.GetComponent<LifeScript>().Break();
//                }
//                else
//                {
//                    if (lifeObject1 != null)
//                    {
//                        lifeObject1.GetComponent<LifeScript>().Break();
//                    }
//                    else
//                    {   
//                        scoreComp.isGame = false;
//                        SceneManager.LoadScene("EndScene");
//                    }
//                }
//            }
//        }
//        if (col.gameObject.tag == "Tiger")
//        {
//            if (lifeObject3 != null)
//            {
//                lifeObject3.GetComponent<LifeScript>().Break();
//            }
//            else
//            {
//                if (lifeObject2 != null)
//                {
//                    lifeObject2.GetComponent<LifeScript>().Break();
//                }
//                else
//                {
//                    if (lifeObject1 != null)
//                    {
//                        lifeObject1.GetComponent<LifeScript>().Break();
                        
//                    }
//                    else
//                    {
//                        scoreComp.isGame = false;
//                        SceneManager.LoadScene("EndScene");
//                    }
//                }
//            }
//        }
//    }
}
