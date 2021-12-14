using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SnareGenerator : MonoBehaviour
{
    const float CREATE_INTERVAL = 0.4f;  //장애물이 생성되는 시간 주기 설정
    float mCreatTime = 0;
    float mTotalTIme = 0;

    float mNextCreateInterval = CREATE_INTERVAL;

    int mPhase = 1;

    public GameObject mSnare;

    private void Update()
    {
        mTotalTIme += Time.deltaTime;
        mCreatTime += Time.deltaTime;
        if (mCreatTime > mNextCreateInterval)
        {
            mCreatTime = 0;
            mNextCreateInterval = CREATE_INTERVAL - (0.005f * mTotalTIme); 

            if (mNextCreateInterval < 0.0000005f)  //하나의 장애물이 생성된 후 다음 장애물이 생성될 때의 주기 설정
            {
                mNextCreateInterval = 0.0000005f;
            }

            for (int i = 0; i < mPhase; i++)
            {
                creatSnare(34f + i * 0.2f);  //장애물이 생성되는 스팟의 높이, 범위
            }

        }

        if (mTotalTIme >= 10f)
        {
            mTotalTIme = 0; 
        }
    }

    private void creatSnare(float y)
    {
        float x = Random.Range(-80f, 80f);  //장애물이 생성되는 스팟의 가로 범위
        createObject(mSnare, new Vector3(x, y, 0), Quaternion.identity);
    }


    private GameObject createObject(GameObject original, Vector3 position, Quaternion rotation)
    {
        return (GameObject)Instantiate(original, position, rotation);
    }


    }
