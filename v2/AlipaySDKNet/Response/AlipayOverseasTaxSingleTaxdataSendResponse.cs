using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxSingleTaxdataSendResponse.
    /// </summary>
    public class AlipayOverseasTaxSingleTaxdataSendResponse : AopResponse
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// The actual payment time. 仅放款完成时存在，格式为yyyy-mm-dd hh:mm:ss format.
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付宝流水号,退税单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户登录id
        /// </summary>
        [XmlElement("user_login_id")]
        public string UserLoginId { get; set; }
    }
}
