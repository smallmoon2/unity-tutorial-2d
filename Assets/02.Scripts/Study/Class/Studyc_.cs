using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Studyc_ : MonoBehaviour
{
    List<Orc> orcs = new List<Orc>();
    List<Goblin> goblin = new List<Goblin>();
    List<Monster> monster = new List<Monster>();
    void Start()
    {
        Monster m = new Monster();

        
        Orc o3 = m as Orc;

        Debug.Log(o3);
        //Orc o2 = (Orc)m;


        //Orc o = new Orc();
        //Goblin g = new Goblin();

        //// �ٿ�ĳ����
        //Monster m5 = new Monster();
        //Orc o2 = (Orc)m5;


        //// ��ĳ���� ����� ����ȯ
        //Monster m1 = (Monster)o;
        //Monster m2 = (Monster)g;

        //// ��ĳ���� �Ͻ��� ����ȯ
        //Monster m3 = o;
        //Monster m4 = g;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
