using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPips : MonoBehaviour
{
    public int totalHealth;
    public int currentHealth;
    [SerializeField]
    private List<GameObject> healthPips = new List<GameObject>();
    private List<Animator> pipAnimator = new List<Animator>();
    [SerializeField]
    private GameObject healthPipPrefab;
    [SerializeField]
    private Transform healthPipCanvas;
    public int lastDamaged = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateTotalHealth();
    }

    public void UpdateTotalHealth()
    {
        for(int i = 0; i < totalHealth; i++)
        {
            Instantiate(healthPipPrefab, healthPipCanvas);
            healthPips.Add(transform.GetChild(i).gameObject);
            pipAnimator.Add(healthPips[i].GetComponent<Animator>());
        }

        int damage = totalHealth - currentHealth;

        for(int i = 0; i < damage; i++)
        {
            pipAnimator[i].SetBool("IsDamaged", true);
            lastDamaged = i;
        }
    }

    public void TakeDamage(int amount)
    {
        int damageToTake = Mathf.Clamp(amount, 0, (totalHealth - (lastDamaged + 1)));
            
        for(int i = 0; i < damageToTake; i++)
        {                                               
            lastDamaged++;
            pipAnimator[lastDamaged].SetBool("IsDamaged", true);                                        
        }
    }

    public void HealDamage(int amount)
    {
        int damageToHeal = Mathf.Clamp(amount, 0, (lastDamaged + 1));

        for(int i = 0; i < damageToHeal; i++)
        {                                                    
            pipAnimator[lastDamaged].SetBool("IsDamaged", false);
            lastDamaged--;                                       
        }
    }
}
