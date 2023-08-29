using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoomTrigger : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //}
    public int indexScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<WitcherMove>() != null)
        {
            SceneManager.LoadScene(indexScene);
        }
    }
}
