using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInviteQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeInviteQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 支付宝服务商小程序跳入企业码小程序签约链接
        /// </summary>
        [XmlElement("mini_app_sign_url")]
        public string MiniAppSignUrl { get; set; }

        /// <summary>
        /// 签约吱口令
        /// </summary>
        [XmlElement("share_code")]
        public string ShareCode { get; set; }

        /// <summary>
        /// 邀请链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
