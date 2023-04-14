using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookNotifySubscribeResponse.
    /// </summary>
    public class AlipayFundAccountbookNotifySubscribeResponse : AopResponse
    {
        /// <summary>
        /// 记账本ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 响应code。 成功为10000； 业务异常为40004；
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 响应描述。 成功为Success； 业务异常为Business Failed；
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 订阅关系状态， VALID：有效的； INVALID：失效的；
        /// </summary>
        [XmlElement("subscribe_status")]
        public string SubscribeStatus { get; set; }
    }
}
