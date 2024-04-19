using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvFundTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvFundTransferModel : AopObject
    {
        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 交易请求号，以yyyyMMdd时间串格式开始，在调用方系统、内需要保持全局唯一，是判断幂等逻辑请求唯一识别码。
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 资金管控划拨金额，单位: 元
        /// </summary>
        [XmlElement("transfer_amount")]
        public string TransferAmount { get; set; }

        /// <summary>
        /// 是否释放剩余余额。指在本次划拨请求时，是否释放除本次划拨金额的剩余余额部分
        /// </summary>
        [XmlElement("unfreeze_balance_flag")]
        public bool UnfreezeBalanceFlag { get; set; }
    }
}
