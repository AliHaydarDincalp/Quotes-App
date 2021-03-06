﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreProcess : MonoBehaviour
{
    public QuoteDB[] quotedb;

    

    void Start()
    {

        TextAsset quoteData = Resources.Load<TextAsset>("Database/alldataexcel-10");
        string[] data = quoteData.text.Split(new char[] { '\n' });

        quotedb = new QuoteDB[data.Length];

        for (int i = 1; i < data.Length; i++)
        {
            string[] row = data[i].Split(new char[] { ';' });

            quotedb[i - 1] = new QuoteDB(row[0], row[1], row[2], row[3]);
        }
    }
}
