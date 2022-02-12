using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_ToggleMenu : MonoBehaviour
{
    private GameManager_Master gm_master;
    public GameObject menu;
    void Start()
    {
        ToggleMenu();
    }

    void Update()
    {
        CheckMenuRequest();
    }

    void OnEnable()
    {
        SetInitial();
        gm_master.GameOverEvent += ToggleMenu;
    }

    void OnDisable()
    {
        gm_master.GameOverEvent -= ToggleMenu;
    }

    void SetInitial()
    {
        gm_master = GetComponent<GameManager_Master>();
    }

    void CheckMenuRequest()
    {
        if(Input.GetKeyUp(KeyCode.Escape) && !gm_master.isGameOver)
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        if(menu != null)
        {
            menu.SetActive(!menu.activeSelf);
            gm_master.isMenuOn = !gm_master.isMenuOn;
            gm_master.CallEventMenuToggle();
        }
    }
}
