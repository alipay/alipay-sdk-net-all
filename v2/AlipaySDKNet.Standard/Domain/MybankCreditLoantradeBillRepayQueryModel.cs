using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillRepayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeBillRepayQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝Id,无需脱敏
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 方案合约编号，机构授权综合合约号
        /// </summary>
        [XmlElement("auth_ar_no")]
        public string AuthArNo { get; set; }

        /// <summary>
        /// 支付宝Id,无需脱敏
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 提交代客还款时的请求编号
        /// </summary>
        [XmlElement("repay_request_no")]
        public string RepayRequestNo { get; set; }
    }
}
