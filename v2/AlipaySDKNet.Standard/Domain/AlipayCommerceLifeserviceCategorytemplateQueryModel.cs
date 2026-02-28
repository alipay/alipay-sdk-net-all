using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceCategorytemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceCategorytemplateQueryModel : AopObject
    {
        /// <summary>
        /// 属性类型
        /// </summary>
        [XmlElement("attr_type")]
        public string AttrType { get; set; }

        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }
    }
}
