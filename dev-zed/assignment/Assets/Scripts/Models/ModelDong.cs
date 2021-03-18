using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ModelApi
{
    public bool success;
    public int code;
    public List<ModelDong> data;
}

[Serializable]
public class ModelDong
{
    public List<ModelRoomTypes> roomtypes;
    public ModelDongMeta meta;
}

[Serializable]
public class ModelRoomTypes
{
    public List<string> coordinatesBase64s;
    public ModelRoomTypesMeta meta;
}

[Serializable]
public class ModelRoomTypesMeta
{
    public int roomtype_id;
}

[Serializable]
public class ModelDongMeta
{
    public int bd_id;
    public int bd_num;
    public int height;
}