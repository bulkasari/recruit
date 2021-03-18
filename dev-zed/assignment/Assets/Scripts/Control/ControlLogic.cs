using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLogic : MonoBehaviour
{
    ModelApi mModelDong;
    public void OnAwake()
    {
        string strContent = Resources.Load("Samples/json/dong").ToString();
        strContent = strContent.Replace("동", "bd_num");
        strContent = strContent.Replace("지면높이", "height");
        strContent = strContent.Replace("룸타입id", "roomtype_id");

        mModelDong = JsonUtility.FromJson<ModelApi>(strContent);
        List<ModelDong> listData = mModelDong.data;
        for (int i = 0; i < listData.Count; ++i)
        {
            ModelDong dataDong = listData[i];
            for (int j = 0; j < dataDong.roomtypes.Count; ++j)
            {
                byte[] buffer = Convert.FromBase64String(dataDong.roomtypes[j].coordinatesBase64s[0]);
                float[] samples = new float[buffer.Length];
                Buffer.BlockCopy(buffer, 0, samples, 0, buffer.Length);

                for (int num = 0; num < samples.Length; ++num)
                {
                    Debug.Log(samples[num]);
                }
            }
            //Debug.Log(listData[i].roomtypes.coordinatesBase64s);
            //Debug.Log(listData[i].roomtypes.meta.roomtype_id);
            //Debug.Log(listData[i].meta.bd_num);
            //Debug.Log(listData[i].meta.height);
        }
    }
    public void OnUpdate()
    {

    }
}
