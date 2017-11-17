using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;


public class scoreManger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        trier(30);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void trier(int newScore)
    {
        var listTrier= new List<int>();
        listTrier = read();

        listTrier.Add(newScore);
        print(listTrier);
       // listTrier = listTrier.Sort();
        listTrier.Sort();
        print(listTrier[0]);
        //ecrire dans le fichier 
        string[] str = new string[] { listTrier[3].ToString(), listTrier[2].ToString(), listTrier[1].ToString() };
        using(StreamWriter sr=new StreamWriter("score.txt"))
        {
            foreach (string s in str)
            {
                sr.WriteLine(s);
            }
        }

    }

    public List<int> read()
    {
        
        var list = new List<int>();
        var fileStream = new FileStream(@"score.txt",FileMode.Open,FileAccess.Read);

        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                list.Add(int.Parse(line));
            }
        }

        
        return list;

    }
}
