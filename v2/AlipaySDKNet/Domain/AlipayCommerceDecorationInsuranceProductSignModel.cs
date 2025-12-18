using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDecorationInsuranceProductSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDecorationInsuranceProductSignModel : AopObject
    {
        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact_info")]
        public string ContactInfo { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_user")]
        public string ContactUser { get; set; }

        /// <summary>
        /// 付款企业信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 付款企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 付款企业pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("product_type_list")]
        [XmlArrayItem("string")]
        public List<string> ProductTypeList { get; set; }
    }
}
