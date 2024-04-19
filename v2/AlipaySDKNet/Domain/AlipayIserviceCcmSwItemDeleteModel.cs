using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwItemDeleteModel : AopObject
    {
        /// <summary>
        /// 事项id集合
        /// </summary>
        [XmlArray("item_codes")]
        [XmlArrayItem("string")]
        public List<string> ItemCodes { get; set; }

        /// <summary>
        /// 外部透传批量操作id，用于问题排查
        /// </summary>
        [XmlElement("syn_id")]
        public string SynId { get; set; }
    }
}
