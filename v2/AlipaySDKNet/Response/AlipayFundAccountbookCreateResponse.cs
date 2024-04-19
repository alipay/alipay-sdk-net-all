using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookCreateResponse.
    /// </summary>
    public class AlipayFundAccountbookCreateResponse : AopResponse
    {
        /// <summary>
        /// 开通的资金记账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 网银入金的外标卡信息
        /// </summary>
        [XmlElement("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
