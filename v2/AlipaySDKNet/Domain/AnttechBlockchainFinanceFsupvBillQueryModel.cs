using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvBillQueryModel : AopObject
    {
        /// <summary>
        /// 资金管控产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 对账单日期
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 管控方证件号码，一般为企业统一社会信用代码
        /// </summary>
        [XmlElement("supervisor_id_number")]
        public string SupervisorIdNumber { get; set; }

        /// <summary>
        /// 资金管控任务编码
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
