using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentCallbackBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentCallbackBizDetail : AopObject
    {
        /// <summary>
        /// 单期履约结果
        /// </summary>
        [XmlElement("repayment_results")]
        public string RepaymentResults { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
