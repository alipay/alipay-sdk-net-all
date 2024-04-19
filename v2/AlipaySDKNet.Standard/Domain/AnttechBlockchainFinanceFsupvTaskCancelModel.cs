using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvTaskCancelModel : AopObject
    {
        /// <summary>
        /// 资金管控任务产品码，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("fund_supv_product_code")]
        public string FundSupvProductCode { get; set; }

        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 管控方证件号码, ISV服务商接入时必传
        /// </summary>
        [XmlElement("supervisor_id_number")]
        public string SupervisorIdNumber { get; set; }
    }
}
