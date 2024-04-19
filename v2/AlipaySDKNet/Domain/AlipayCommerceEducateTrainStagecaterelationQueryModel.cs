using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainStagecaterelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainStagecaterelationQueryModel : AopObject
    {
        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子产品码
        /// </summary>
        [XmlElement("sub_product_code")]
        public string SubProductCode { get; set; }
    }
}
