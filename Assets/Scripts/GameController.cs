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

    public void HandlePickup(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Gem":
                Gems++;
                textGems.text = Gems.ToString();
                Destroy(obj);
                break;
            case "Emerald":
                Emeralds++;
                textEmeralds.text = Emeralds.ToString();
                Destroy(obj);
                break;
            default:
                break;
        }
    }

}
