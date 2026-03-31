using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandChannelpoiCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandChannelpoiCreateModel : AopObject
    {
        /// <summary>
        /// 数字化门店信息
        /// </summary>
        [XmlElement("digital_poi")]
        public DigitalPoi DigitalPoi { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
