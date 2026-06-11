using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeUserMappingQueryResponse.
    /// </summary>
    public class ZhimaCreditPeUserMappingQueryResponse : AopResponse
    {
        /// <summary>
        /// 开通/授权成功后生成的协议号，用于标记本次开通/授权的唯一标识
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 芝麻分映射到白鹭分的结果，例如映射后的白鹭分：710
        /// </summary>
        [XmlElement("mapped_score")]
        public string MappedScore { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 经过加密后的用户的身份证号码
        /// </summary>
        [XmlElement("user_cert_no")]
        public ZmUserDetailModel UserCertNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 经过加密后的用户的真实姓名
        /// </summary>
        [XmlElement("user_name")]
        public ZmUserDetailModel UserName { get; set; }

        /// <summary>
        /// 经过加密后的用户的手机号码
        /// </summary>
        [XmlElement("user_phone")]
        public ZmUserDetailModel UserPhone { get; set; }
    }
}
