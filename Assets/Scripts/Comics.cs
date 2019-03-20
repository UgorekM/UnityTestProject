using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Comics : MonoBehaviour
{
    public GameObject img1, img2, cld1, cld2, text1, text2;


    void Start()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        yield return StartCoroutine(FadeIn(img1));
        yield return StartCoroutine(FadeIn(cld1, text1));
        yield return StartCoroutine(FadeOut(img1, cld1, text1));
        yield return StartCoroutine(FadeIn(img2));
        yield return StartCoroutine(FadeIn(cld2, text2));
        yield return StartCoroutine(FadeOut(img2, cld2, text2));

        Application.LoadLevel("Main");

    }



    IEnumerator FadeIn(GameObject image)
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            image.GetComponent<Image>().color = new Color(1, 1, 1, 0 + f);
            yield return new WaitForSeconds(0.05f);
        }
    }
    IEnumerator FadeIn(GameObject image1, GameObject image2)
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            image1.GetComponent<Image>().color = new Color(1, 1, 1, 0 + f);
            image2.GetComponent<Image>().color = new Color(1, 1, 1, 0 + f);
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator FadeOut(GameObject image1, GameObject image2, GameObject image3)
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            image1.GetComponent<Image>().color = new Color(1, 1, 1, 1 - f);
            image2.GetComponent<Image>().color = new Color(1, 1, 1, 1 - f);
            image3.GetComponent<Image>().color = new Color(1, 1, 1, 1 - f);
            yield return new WaitForSeconds(0.05f);
        }
        image1.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        image2.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        image3.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }    
}
