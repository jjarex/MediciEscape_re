using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

// 1. 태어날때 GameOver를 보이지 않게 하고싶다.
// 2. Enemy와 Player가 충돌했을때 GameOver를 보이게 하고싶다.(싱글톤)
// 3. 만약 재시작버튼을 누르면 동작할 기능을 만들고 버튼에 연결하고싶다.
// 4. 만약 종료버튼을 누르면 동작할 기능을 만들고 버튼에 연결하고 싶다.
// 5. 만약 힌트버튼을 누르면 힌트UI이가 뜨는 기능을 만들고 버튼에 연결하고 싶다.
// 6. 만약 들어가기버튼을 누르면 도어UI는 사라지고 도어2UI가 나온후 2초뒤 사라지게 하고싶다.

public class GameManager : MonoBehaviour
{
    public SteamVR_Action_Boolean menu;
    bool menuOn = false;
    // 싱글톤
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    // GameOver
    public GameObject gameOverUI;

    public GameObject HintUI;

    public GameObject doorUI;

    public GameObject door2UI;

    public GameObject MinimapUI;

    public GameObject SettingUI;

    public GameObject QRcordUI;

    public GameObject XUI;

    // Start is called before the first frame update
    void Start()
    {
        

        // 1. 태어날때 GameOver를 보이지 않게 하고싶다.
        gameOverUI.SetActive(false); //게임오브젝트를 켜고 끄는 기능
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

    // 5. 만약 힌트버튼을 누르면 힌트UI이가 뜨는 기능을 만들고 버튼에 연결하고 싶다.
    // 그리고 x버튼을 누르면 끄고싶다.
    public void OnClickHint()
    {
        HintUI.SetActive(true);
    }

    public void OnClickX()
    {
        HintUI.SetActive(false);
    }

    // 6. 만약 들어가기버튼을 누르면 도어UI는 사라지고 도어2UI가 나온후 2초뒤 사라지게 하고싶다.
    public void OnClickInGame()
    {
        doorUI.SetActive(false);
        door2UI.SetActive(true);

        StartCoroutine(DisableDoor2UI());
    }

    public void OnClickMinimap()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {  
            //// 만약에 MinimapUi 켜져있으면
            //if(MinimapUI.activeSelf == true)
            //{
            //    // MinimapUi 를 끄자
            //    MinimapUI.SetActive(false);
            //}            
            //// 만약에 MinimapUi 꺼져있으면
            //else if(MinimapUI.activeSelf == false)
            //{
            //    // MinimapUi 를 켜자
            //    MinimapUI.SetActive(true);
            //}
            MinimapUI.SetActive(!MinimapUI.activeSelf);
        }
    }

    public void OnClickSetting()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SettingUI.SetActive(!SettingUI.activeSelf);
            QRcordUI.SetActive(!QRcordUI.activeSelf);
        }
    }

    IEnumerator DisableDoor2UI()
    {
        yield return new WaitForSeconds(2);
        door2UI.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (menu.GetStateDown(SteamVR_Input_Sources.RightHand) || menu.GetStateDown(SteamVR_Input_Sources.LeftHand))
            MenuOn();
        if (menuOn)
        {
            OnClickSetting();
            OnClickMinimap();
        }
    }
    void MenuOn()
    {
        menuOn = !menuOn;
    }
}
