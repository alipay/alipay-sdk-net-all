using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceAccidentriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceAccidentriskQueryModel : AopObject
    {
        /// <summary>
        /// 投保人身份信息，格式为：SHA256(身份证号)。 注意：身份证号需要大写之后做SHA256计算。
        /// </summary>
        [XmlElement("applicant_cert_no")]
        public string ApplicantCertNo { get; set; }

        /// <summary>
        /// 当前风险判定以投保人为主还是以被保人为主。若以投保人为主，则值为applicant， 若以被保人为主，则值为insured。
        /// </summary>
        [XmlElement("assess_priority")]
        public string AssessPriority { get; set; }

        /// <summary>
        /// 授权协议信息，由授权协议地址和授权协议号组成，中间通过'#'符号分隔，格式为: 授权协议地址#授权协议号。
        /// </summary>
        [XmlElement("auth_agreement")]
        public string AuthAgreement { get; set; }

        /// <summary>
        /// 业务ID，服务调用方生成并确保全局唯一。服务是否基于该参数保证幂等性，服务调用方需提前确认。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 保额，单位为元。
        /// </summary>
        [XmlElement("insured_amt")]
        public string InsuredAmt { get; set; }

        /// <summary>
        /// 被保人身份信息，格式为：SHA256(身份证号)。 注意：身份证号需要大写之后做SHA256计算。
        /// </summary>
        [XmlElement("insured_cert_no")]
        public string InsuredCertNo { get; set; }

        /// <summary>
        /// 对客产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 被保人职业等级
        /// </summary>
        [XmlElement("profession_level")]
        public string ProfessionLevel { get; set; }
    }
}
