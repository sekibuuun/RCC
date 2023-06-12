using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript2 : MonoBehaviour
{
    GameObject scoreObject;
    GameObject lifeObject1;
    GameObject lifeObject2;
    GameObject lifeObject3;

    public ScoreScript scoreComp;

    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("TotalScore");
        lifeObject1 = GameObject.Find("Life1");
        lifeObject2 = GameObject.Find("Life2");
        lifeObject3 = GameObject.Find("Life3");

        this.gameObject.GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "100dol")
        {
            scoreObject.GetComponent<ScoreScript>().Dol_100();
        }
        if (col.gameObject.tag == "1000dol")
        {
            scoreObject.GetComponent<ScoreScript>().Dol_1000();
        }
        if (col.gameObject.tag == "Barrier")
        {
            if (lifeObject3 != null)
            {
                lifeObject3.GetComponent<LifeScript>().Break();
            }
            else
            {
                if (lifeObject2 != null)
                {
                    lifeObject2.GetComponent<LifeScript>().Break();
                }
                else
                {
                    if (lifeObject1 != null)
                    {
                        lifeObject1.GetComponent<LifeScript>().Break();
                    }
                    else
                    {
                        scoreComp.isGame = false;
                        SceneManager.LoadScene("EndScene");
                    }
                }
            }
        }
        if (col.gameObject.tag == "Tiger")
        {
            if (lifeObject3 != null)
            {
                lifeObject3.GetComponent<LifeScript>().Break();
            }
            else
            {
                if (lifeObject2 != null)
                {
                    lifeObject2.GetComponent<LifeScript>().Break();
                }
                else
                {
                    if (lifeObject1 != null)
                    {
                        lifeObject1.GetComponent<LifeScript>().Break();

                    }
                    else
                    {
                        scoreComp.isGame = false;
                        SceneManager.LoadScene("EndScene");
                    }
                }
            }
        }
    }
}
