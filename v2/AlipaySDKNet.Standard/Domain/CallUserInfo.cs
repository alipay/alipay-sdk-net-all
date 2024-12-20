using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CallUserInfo : AopObject
    {
        /// <summary>
        /// 触达类型为AI_CALL时，逾期金额为必填项
        /// </summary>
        [XmlElement("amount_overdue")]
        public string AmountOverdue { get; set; }

        /// <summary>
        /// 触达用户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 触达用户电话号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 短信信息中嵌入的链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
