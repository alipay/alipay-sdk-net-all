using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalkPathMetaDataResult Data Structure.
    /// </summary>
    [Serializable]
    public class WalkPathMetaDataResult : AopObject
    {
        /// <summary>
        /// 路线元数据列表
        /// </summary>
        [XmlArray("paths")]
        [XmlArrayItem("walk_path_meta_data")]
        public List<WalkPathMetaData> Paths { get; set; }
    }
}
