﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHard : MonoBehaviour
{
    public GameObject AstOne;
    public GameObject AstTwo;
    public GameObject AstThree;

    public GameObject AsterOne;
    public GameObject AsterTwo;
    public GameObject AsterThree;

    public GameObject JetOne;
    public GameObject JetTwo;
    public GameObject JetThree;
    public GameObject MagicStick;
    public GameObject EnemyOne;
    public AudioSource VoiceOne;
    public AudioSource VoiceTwo;

    public GameObject Fr1;
    public GameObject Fr3;
    public GameObject Fr4;
    public GameObject Fr5;
    public GameObject Fr6;
    public GameObject Fr7;

    public GameObject EOne;
    public GameObject ETwo;
    public GameObject EThree;
    public GameObject EFore;
    public GameObject EFive;
    public GameObject ESix;
    public GameObject ESeven;
    public GameObject EMore;
    public GameObject EFuck;

    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public GameObject E5;
    public GameObject E6;
    public GameObject E7;
    public GameObject E8;
    public GameObject E9;
    public GameObject E10;
    public GameObject E11;
    public GameObject E12;
    public GameObject E13;
    public GameObject E14;
    public GameObject E15;
    public GameObject E16;
    public GameObject E17;
    public GameObject E18;
    public GameObject E19;
    public GameObject E20;
    public GameObject E21;
    public GameObject E22;
    public GameObject E23;
    public GameObject E24;
    public GameObject E25;
    public GameObject E26;
    public GameObject E01;
    public GameObject E02;
    public GameObject E03;
    public GameObject E04;
    public GameObject E05;
    public GameObject E06;
    public GameObject E07;
    public GameObject E08;
    public GameObject E09;
    public GameObject E010;
    public GameObject E011;
    public GameObject E012;
    public GameObject E013;
    public GameObject E014;
    public GameObject E015;
    public GameObject E016;
    public GameObject E017;
    public GameObject E018;
    public GameObject E019;
    public GameObject E020;
    public GameObject E021;
    public GameObject E022;
    public GameObject E023;
    public GameObject E024;
    public GameObject E025;

    void Start()
    {
  
        MagicStick.SetActive(false);
   
        StartCoroutine(Normal());   
    }
    IEnumerator Normal()
    {
        yield return new WaitForSeconds(1);
        AstOne.SetActive(true);
        yield return new WaitForSeconds(1);
        JetOne.SetActive(true);
        VoiceOne.Play();
        yield return new WaitForSeconds(1);
        AstTwo.SetActive(true);
        yield return new WaitForSeconds(1);
        JetTwo.SetActive(true);
        yield return new WaitForSeconds(1);
        AstThree.SetActive(true);
        yield return new WaitForSeconds(1);
        VoiceTwo.Play();
        JetThree.SetActive(true);
        yield return new WaitForSeconds(1);
        EnemyOne.SetActive(true);
        yield return new WaitForSeconds(3);

        MagicStick.SetActive(true);
        //AstOne.SetActive(false);
        //AstTwo.SetActive(false);
        //AstThree.SetActive(false);
        JetOne.SetActive(false);
        JetTwo.SetActive(false);
        JetThree.SetActive(false);

        yield return new WaitForSeconds(2);
        AsterOne.SetActive(true);
        EOne.SetActive(true);
        yield return new WaitForSeconds(1);
        ETwo.SetActive(true);
        yield return new WaitForSeconds(4);
        EnemyOne.SetActive(false);
        EThree.SetActive(true);
        yield return new WaitForSeconds(1);

        Fr1.SetActive(true);

        EOne.SetActive(false);
        ETwo.SetActive(false);
        EFore.SetActive(true);
        yield return new WaitForSeconds(1);
        EFive.SetActive(true);
        yield return new WaitForSeconds(1);
        ESix.SetActive(true);
        yield return new WaitForSeconds(1);
        AsterTwo.SetActive(true);
        ESeven.SetActive(true);
        yield return new WaitForSeconds(1);
        EThree.SetActive(false);
        EMore.SetActive(true);
        yield return new WaitForSeconds(1);

        Fr1.SetActive(false);
        Fr3.SetActive(true);

        EFore.SetActive(false);
        EFuck.SetActive(true);
        yield return new WaitForSeconds(1);
        EFive.SetActive(false);
        E1.SetActive(true);
        yield return new WaitForSeconds(1);
        E2.SetActive(true);
        ESix.SetActive(false);
        yield return new WaitForSeconds(1);
        E3.SetActive(true);
        ESeven.SetActive(false);
        yield return new WaitForSeconds(1);
        E4.SetActive(true);
        E5.SetActive(true);
        EMore.SetActive(false);
        yield return new WaitForSeconds(1);

        Fr3.SetActive(false);
        Fr4.SetActive(true);

        AsterThree.SetActive(true);
        E6.SetActive(true);
        EFuck.SetActive(false);
        yield return new WaitForSeconds(1);
        E7.SetActive(true);
        E8.SetActive(true);
        E1.SetActive(false);
        yield return new WaitForSeconds(1);
        E9.SetActive(true);
        E2.SetActive(false);
        yield return new WaitForSeconds(1);
        VoiceOne.Play();
        E10.SetActive(true);
        E11.SetActive(true);
        E3.SetActive(false);
        yield return new WaitForSeconds(1);
        E12.SetActive(true);
        E4.SetActive(false);
        E5.SetActive(false);
        yield return new WaitForSeconds(1);

        Fr4.SetActive(false);
        Fr5.SetActive(true);

        E13.SetActive(true);
        E6.SetActive(false);
        yield return new WaitForSeconds(1);
        E14.SetActive(true);
        E15.SetActive(true);
        E16.SetActive(true);
        E7.SetActive(false);
        E8.SetActive(false);
        yield return new WaitForSeconds(1);
        E17.SetActive(true);
        E18.SetActive(true);
        E9.SetActive(false);
        yield return new WaitForSeconds(1);
        E19.SetActive(true);
        E20.SetActive(true);
        E10.SetActive(false);
        E11.SetActive(false);
        yield return new WaitForSeconds(1);
        E21.SetActive(true);
        E22.SetActive(true);
        E12.SetActive(false);
        yield return new WaitForSeconds(1);

        Fr5.SetActive(false);
        Fr6.SetActive(true);

        E23.SetActive(true);
        E24.SetActive(true);
        E25.SetActive(true);
        E13.SetActive(false);
        yield return new WaitForSeconds(1);
        E26.SetActive(true);
        E01.SetActive(true);
        E14.SetActive(false);
        E15.SetActive(false);
        E16.SetActive(false);
        yield return new WaitForSeconds(1);
        E02.SetActive(true);
        E03.SetActive(true);
        E04.SetActive(true);
        E17.SetActive(false);
        E18.SetActive(false);
        yield return new WaitForSeconds(1);
        E05.SetActive(true);
        E06.SetActive(true);
        E19.SetActive(false);
        E20.SetActive(false);
        yield return new WaitForSeconds(1);
        E07.SetActive(true);
        E08.SetActive(true);
        E09.SetActive(true);
        E21.SetActive(false);
        E22.SetActive(false);
        yield return new WaitForSeconds(1);

        Fr5.SetActive(false);
        Fr6.SetActive(true);

        E010.SetActive(true);
        E011.SetActive(true);
        E23.SetActive(false);
        E24.SetActive(false);
        E25.SetActive(false);
        yield return new WaitForSeconds(1);
        E012.SetActive(true);
        E013.SetActive(true);
        E014.SetActive(true);
        E26.SetActive(false);
        E01.SetActive(false);
        yield return new WaitForSeconds(1);
        E015.SetActive(true);
        E016.SetActive(true);
        E02.SetActive(false);
        E03.SetActive(false);
        E04.SetActive(false);
        yield return new WaitForSeconds(1);
        E017.SetActive(true);
        E018.SetActive(true);
        E019.SetActive(true);
        E05.SetActive(false);
        E06.SetActive(false);
        yield return new WaitForSeconds(1);
        E020.SetActive(true);
        E021.SetActive(true);
        E07.SetActive(false);
        E08.SetActive(false);
        E09.SetActive(false);
        yield return new WaitForSeconds(1);

        Fr6.SetActive(false);
        Fr7.SetActive(true);

        E022.SetActive(true);
        E023.SetActive(true);
        E010.SetActive(false);
        E011.SetActive(false);
        yield return new WaitForSeconds(1);
        E025.SetActive(true);
        E024.SetActive(true);
        E012.SetActive(false);
        E013.SetActive(false);
        E014.SetActive(false);
        yield return new WaitForSeconds(1);
        E015.SetActive(false);
        E016.SetActive(false);
        yield return new WaitForSeconds(1);
        E017.SetActive(false);
        E018.SetActive(false);
        E019.SetActive(false);
        yield return new WaitForSeconds(1);
        E020.SetActive(false);
        E021.SetActive(false);
        yield return new WaitForSeconds(1);

        Fr7.SetActive(false);

        E022.SetActive(false);
        E023.SetActive(false);
        yield return new WaitForSeconds(1);
        E024.SetActive(false);
        E025.SetActive(false);
        MagicStick.SetActive(false);
        yield return new WaitForSeconds(1);
        VoiceTwo.Play();
    }
}
