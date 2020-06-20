using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public TextMeshProUGUI textGems;
    public TextMeshProUGUI textEmeralds;
    public HealthBar healthBar;

    private const int MaxLifePoints = 100;
    private int LifePoints;

    private int Gems;
    private int Emeralds;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }

    void Start()
    {
        LifePoints = MaxLifePoints;
        Gems = Emeralds = 0;
        healthBar.SetMaxHealth(MaxLifePoints);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleDamage(10);
        }
    }

    public void HandleDamage(int damage)
    {
        LifePoints = Mathf.Clamp(LifePoints - damage, 0, MaxLifePoints);
        healthBar.SetHealth(LifePoints);

        if(LifePoints == 0)
        {
            print("Te moriste boludo");
        }
    }

    public void HandlePickable(Constants.Pickable tag)
    {
        switch (tag)
        {
            case Constants.Pickable.Gem:
                Gems++;
                textGems.text = Gems.ToString();
                break;
            case Constants.Pickable.Emerald:
                Emeralds++;
                textEmeralds.text = Emeralds.ToString();
                break;
            case Constants.Pickable.Cherry:
                LifePoints = Mathf.Clamp(LifePoints + Constants.CherryHealthRecovery, 0, MaxLifePoints);
                healthBar.SetHealth(LifePoints);
                break;
            default:
                break;

        }

    }

}
