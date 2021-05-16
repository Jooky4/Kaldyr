using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт для скрытия стен магазина


public class InvisibleArea : MonoBehaviour
{
    [SerializeField]
    private GameObject SideSprite1; // спрайты 
    [SerializeField]
    private GameObject SideSprite2; // стен

    // Start is called before the first frame update
    void Start()
    {
        SideSprite1.SetActive(true); // вкл
        SideSprite2.SetActive(true); // стены
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("InSide");
            SideSprite1.SetActive(false); // если  игрок зашел в магаз
            SideSprite2.SetActive(false); // откл стены
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("OutSide");
            SideSprite1.SetActive(true);  // если  игрок вышел из магаза
            SideSprite2.SetActive(true);  // вкл стены
        }
    }
}
