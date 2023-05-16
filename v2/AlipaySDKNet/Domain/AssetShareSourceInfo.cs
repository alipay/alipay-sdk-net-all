using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetShareSourceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetShareSourceInfo : AopObject
    {
        /// <summary>
        /// 当前规则可用的资产来源类型，搭配source_id_list使用。
        /// </summary>
        [XmlElement("share_mode")]
        public string ShareMode { get; set; }

        /// <summary>
        /// 资产共享来源id列表，与share_mode配合设置
        /// </summary>
        [XmlArray("source_id_list")]
        [XmlArrayItem("string")]
        public List<string> SourceIdList { get; set; }
    }
}
