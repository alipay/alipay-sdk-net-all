using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }
    }
}
