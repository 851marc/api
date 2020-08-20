﻿using System;

namespace Modding
{
    /// <inheritdoc />
    /// <summary>
    ///     Represents a Dictionary of Ints that can be serialized with Unity's JsonUtil
    /// </summary>
    [Serializable]
    public class SerializableIntDictionary : SerializableDictionary<string, int> { }
}