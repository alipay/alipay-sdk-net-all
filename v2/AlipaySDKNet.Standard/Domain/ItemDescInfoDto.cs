using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDescInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDescInfoDto : AopObject
    {
        /// <summary>
        /// 商品详情描述文本（不超过2000字）
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品详情描述图片（最多10张）
        /// </summary>
        [XmlArray("imgs")]
        [XmlArrayItem("string")]
        public List<string> Imgs { get; set; }
    }
}
