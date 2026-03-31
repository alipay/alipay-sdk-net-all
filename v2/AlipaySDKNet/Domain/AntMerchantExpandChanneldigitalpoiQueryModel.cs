using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandChanneldigitalpoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandChanneldigitalpoiQueryModel : AopObject
    {
        /// <summary>
        /// 请求渠道，由后端技术分配
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
