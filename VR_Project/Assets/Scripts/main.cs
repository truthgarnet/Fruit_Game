using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public enum Fruit { Cube1, Cube2, Cube3, Cube4, Cube5, Cube6 };
    
    public GameObject[] Fruitly;
    public GameObject btn;
    public Canvas start;
    bool check1;
 
    Fruit ft;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NCube());
        check1 = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartUI._this.check == true)
            check1 = true;

        int r = Random.Range(0, Fruitly.Length);

        switch (r)
        {
            case 0:
                ft = Fruit.Cube1;
                break;
            case 1:
                ft = Fruit.Cube2;
                break;
            case 2:
                ft = Fruit.Cube3;
                break;
            case 3:
                ft = Fruit.Cube4;
                break;
            case 4:
                ft = Fruit.Cube5;
                break;
            case 5:
                ft = Fruit.Cube6;
                break;
        }
    }

    IEnumerator NCube()
    {
        while (true)
        {
            GameObject target = null;

            switch (ft)
            {
                case Fruit.Cube1:
                    target = Fruitly[0];
                    break;
                case Fruit.Cube2:
                    target = Fruitly[1];
                    break;
                case Fruit.Cube3:
                    target = Fruitly[2];
                    break;
                case Fruit.Cube4:
                    target = Fruitly[3];
                    break;
                case Fruit.Cube5:
                    target = Fruitly[4];
                    break;
                case Fruit.Cube6:
                    target = Fruitly[5];
                    break;
            }


            if (check1 == true)
            {
                Vector3 pos = new Vector3(Random.Range(-0.7f, 0.7f), Random.Range(1.3f, 2.1f), -15);
                GameObject C = GameObject.Instantiate(target, pos, Quaternion.identity);
            }
            
            yield return new WaitForSeconds(0.7f);
        }
    }
  
}