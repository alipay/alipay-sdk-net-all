using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceUserskipQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceUserskipQueryModel : AopObject
    {
        /// <summary>
        /// 证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 平安养老险
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 购买保司产品的企业ID，如：中国移动
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部平台/保司对应的用户id，用于和外部商户约定区分用户的唯一标识
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
