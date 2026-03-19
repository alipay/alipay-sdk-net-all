using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationMcpPhoneCheckResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationMcpPhoneCheckResponse : AopResponse
    {
        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 手机号运营商信息
        /// </summary>
        [XmlElement("mobile_info")]
        public MobileInfo MobileInfo { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机号尾号对应的姓名部分（仅当verfyType为PART_NAME时有值）
        /// </summary>
        [XmlElement("part_mobile_name")]
        public string PartMobileName { get; set; }

        /// <summary>
        /// 风控验证类型
        /// </summary>
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }
    }
}
