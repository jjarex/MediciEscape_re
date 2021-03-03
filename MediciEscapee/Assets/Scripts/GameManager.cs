using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 1. 태어날때 GameOver를 보이지 않게 하고싶다.
// 2. Enemy와 Player가 충돌했을때 GameOver를 보이게 하고싶다.(싱글톤)
// 3. 만약 재시작버튼을 누르면 동작할 기능을 만들고 버튼에 연결하고싶다.
// 4. 만약 종료버튼을 누르면 동작할 기능을 만들고 버튼에 연결하고 싶다.
public class GameManager : MonoBehaviour
{
    // 싱글톤
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    // GameOver
    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        // 1. 태어날때 GameOver를 보이지 않게 하고싶다.
        //gameOverUI.SetActive(false); //게임오브젝트를 켜고 끄는 기능
        // GetComponent<BoxCollider>().enabled = true; 컴포넌트를 켜고 끄는 기능 
    }

    // 3. 만약 재시작버튼을 누르면 동작할 기능을 만들고 버튼에 연결하고싶다.
    public void OnClickRestart()
    {
        //재시작 - 현재 Scene을 로드하고 싶다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // 4. 만약 종료버튼을 누르면 동작할 기능을 만들고 버튼에 연결하고 싶다.
    public void OnClickQuit()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
