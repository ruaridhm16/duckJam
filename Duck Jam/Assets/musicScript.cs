using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScript : MonoBehaviour
{
    public duckCounter duckCount;
    public int level;
 

    [SerializeField] private AudioSource level1Layer1;
    [SerializeField] private AudioSource level1Layer2;
    [SerializeField] private AudioSource level1Layer3;
    [SerializeField] private AudioSource level1Layer4;
    [SerializeField] private AudioSource level1Layer5;

    public bool[] plays = new bool[] { false, false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        if (level == 1)
        {
            level1Layer1.Play(0);
            level1Layer1.volume = 0;
            level1Layer2.Play(0);
            level1Layer2.volume = 0;
            level1Layer3.Play(0);
            level1Layer3.volume = 0;
            level1Layer4.Play(0);
            level1Layer4.volume = 0;
            level1Layer5.Play(0);
            level1Layer5.volume = 0;
        }
    }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(level1Layer1.time);
            Debug.Log(level1Layer2.time);
            Debug.Log(level1Layer3.time);
            Debug.Log(level1Layer4.time);
            Debug.Log(level1Layer5.time);

            if (level == 1)
            {

                if (duckCounter.duckCount == 1 && !plays[0])
                {
                    level1Layer1.volume = 100;
                    plays[0] = true;
                }
                if (duckCounter.duckCount == 2 && !plays[1])
                {
                    level1Layer2.volume = 100;
                    plays[1] = true;
                }
                if (duckCounter.duckCount == 3 && !plays[2])
                {
                    level1Layer3.volume = 100;
                    plays[2] = true;
                }
                if (duckCounter.duckCount == 4 && !plays[3])
                {
                    level1Layer4.volume = 50;
                    plays[3] = true;
                }
                if (duckCounter.duckCount == 5 && !plays[4])
                {
                    level1Layer5.volume = 100;
                    plays[4] = true;
                }

                else if (duckCounter.duckCount == 0)
                {

                    level1Layer1.volume = 0;

                    level1Layer2.volume = 0;

                    level1Layer3.volume = 0;

                    level1Layer4.volume = 0;

                    level1Layer5.volume = 0;
                }
            }

        }
    }

