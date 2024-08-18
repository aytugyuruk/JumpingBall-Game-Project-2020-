using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainCamera : MonoBehaviour
{
    private Transform _target;
    public Vector3 offset;
    public bool restart1, setting1, quit1, carpi1;
    


    void Start()
    {

        _target = GameObject.FindGameObjectWithTag("top").GetComponent<Transform>();
        Application.targetFrameRate = 120;
    }

     void LateUpdate()
    {
        if (_target.position.y >= transform.position.y)
        {
            transform.position = _target.position + offset;
        }
        if (restart1)
        {
            SceneManager.LoadScene("1.Bölüm");
            
        }
        if (quit1)
        {
            SceneManager.LoadScene("menu");
            
        }
        


    }
    public void restart()
    {
        restart1 = true;
    }
    public void setting()
    {
        setting1 = true;
    }
    public void quit()
    {
        quit1 = true;
    }
   

}

