﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureType : MonoBehaviour
{
    
    [Header("Creature Properties")]
    public string myCreatureName;
    public CreatureSpecies myCreatureSpecies;
    public CreatureElement myCreatureElement;
    public CreatureFood myCreatureFood;
    public CreatureGender myCreatureGender;
    public GameObject drop;

    [Header("Creature Stats")]
    public float creatureHealth;
    public float maxCreatureHealth;
    public float creatureHappiness;
    public float maxCreatureHappiness;

    NavMeshAgent myNav;

    void Start()
    {
        gameObject.name = myCreatureSpecies.ToString();
        creatureHealth = maxCreatureHealth;
        //creatureHappiness = maxCreatureHappiness;
        myNav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
    }
}
