using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessPartner Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPartner : AopObject
    {
        /// <summary>
        /// 机构本地名称
        /// </summary>
        [XmlElement("business_local_name")]
        public string BusinessLocalName { get; set; }

        /// <summary>
        /// 商业合作伙伴别名，一般业务场景下所使用，对商户的简称、缩写或别称
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Business logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// logo的类型
        /// </summary>
        [XmlElement("logo_type")]
        public string LogoType { get; set; }

        /// <summary>
        /// Merchant category code
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 营业地址
        /// </summary>
        [XmlElement("operation_address")]
        public OperationAddress OperationAddress { get; set; }
    }
}
