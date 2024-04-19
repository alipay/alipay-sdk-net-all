using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeLeaseSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceIncomeLeaseSubmitResponse : AopResponse
    {
        /// <summary>
        /// 租赁交易登记流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 交易id，租赁交易登记上链后返回
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
