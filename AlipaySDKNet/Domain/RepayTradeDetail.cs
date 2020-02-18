using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepayTradeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RepayTradeDetail : AopObject
    {
        /// <summary>
        /// 交易还款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
