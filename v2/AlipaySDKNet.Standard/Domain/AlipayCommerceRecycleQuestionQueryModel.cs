using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleQuestionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleQuestionQueryModel : AopObject
    {
        /// <summary>
        /// 产品code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
