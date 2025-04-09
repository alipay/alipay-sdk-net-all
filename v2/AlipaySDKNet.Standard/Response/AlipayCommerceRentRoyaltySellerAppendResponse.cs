using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentRoyaltySellerAppendResponse.
    /// </summary>
    public class AlipayCommerceRentRoyaltySellerAppendResponse : AopResponse
    {
        /// <summary>
        /// 单位：元。分账金额执行的实际金额
        /// </summary>
        [XmlElement("execute_amount")]
        public string ExecuteAmount { get; set; }

        /// <summary>
        /// 当前履约号
        /// </summary>
        [XmlElement("installment_id")]
        public string InstallmentId { get; set; }

        /// <summary>
        /// 执行后的代偿资金订单号，也是交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
