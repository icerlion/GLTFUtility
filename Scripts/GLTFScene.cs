﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Siccity.GLTFUtility {
    // https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/README.md#scene
    public class GLTFScene {

#region Serialized fields
        /// <summary> Indices of nodes </summary>
        public List<int> nodes;
        public string name;
#endregion
    }
}