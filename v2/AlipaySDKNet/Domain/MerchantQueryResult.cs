using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantQueryResult : AopObject
    {
        /// <summary>
        /// 商户的别名，用户商户对客展示的名称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 商户认证证件号，企业营业执照号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 商户经营详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("distinct")]
        public string Distinct { get; set; }

        /// <summary>
        /// 商户新版mcc code
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 描述商户类型，个人-P/企业-B
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 商户认证名称信息
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
