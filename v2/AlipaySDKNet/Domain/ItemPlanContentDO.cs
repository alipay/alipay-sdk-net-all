using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPlanContentDO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPlanContentDO : AopObject
    {
        /// <summary>
        /// 对应服务库编码
        /// </summary>
        [XmlArray("codes")]
        [XmlArrayItem("string")]
        public List<string> Codes { get; set; }

        /// <summary>
        /// 条目类型，必须， 商品：ITEM
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
