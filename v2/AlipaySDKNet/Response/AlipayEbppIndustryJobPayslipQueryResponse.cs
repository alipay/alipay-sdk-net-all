using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobPayslipQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryJobPayslipQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户收款账户号码
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 支付宝登录账号: 手机号或者邮箱
        /// </summary>
        [XmlElement("alipay_login_id")]
        public string AlipayLoginId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
