using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CeItemDescInfoModifyVO Data Structure.
    /// </summary>
    [Serializable]
    public class CeItemDescInfoModifyVO : AopObject
    {
        /// <summary>
        /// 商品详情描述文本（不超过2000字）。若接入商品详情页组件，将在详情页组件处透出。
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("imgs")]
        [XmlArrayItem("string")]
        public List<string> Imgs { get; set; }
    }
}
