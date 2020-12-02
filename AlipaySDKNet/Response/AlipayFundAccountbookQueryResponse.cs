using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookQueryResponse.
    /// </summary>
    public class AlipayFundAccountbookQueryResponse : AopResponse
    {
        /// <summary>
        /// 记账账簿id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [XmlElement("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
