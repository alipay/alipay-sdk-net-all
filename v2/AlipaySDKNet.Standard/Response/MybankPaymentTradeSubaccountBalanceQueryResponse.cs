using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeSubaccountBalanceQueryResponse.
    /// </summary>
    public class MybankPaymentTradeSubaccountBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用余额，单位元
        /// </summary>
        [XmlElement("available_balance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// 币种，默认CNY
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 子户外标
        /// </summary>
        [XmlElement("sub_card_no")]
        public string SubCardNo { get; set; }
    }
}
