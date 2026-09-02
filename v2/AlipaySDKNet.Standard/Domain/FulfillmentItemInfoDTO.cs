using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentItemInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentItemInfoDTO : AopObject
    {
        /// <summary>
        /// 外部商户的商品编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
