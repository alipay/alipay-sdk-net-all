using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsureOrderNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsureOrderNotifyModel : AopObject
    {
        /// <summary>
        /// 身份证号，明文
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 用户最近一次理赔状态
        /// </summary>
        [XmlElement("claims_status")]
        public string ClaimsStatus { get; set; }

        /// <summary>
        /// 保司身份标识，由蚂蚁侧提供
        /// </summary>
        [XmlElement("institution_code")]
        public string InstitutionCode { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [XmlElement("insurant_user_name")]
        public string InsurantUserName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 保险增值服务状态
        /// </summary>
        [XmlElement("vas_services_status")]
        public string VasServicesStatus { get; set; }
    }
}
