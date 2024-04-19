using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用购主单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 单位为元。用户实际的冻结金额。
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 用户签约生效时间。未签约时返回为空。
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 已支付
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
