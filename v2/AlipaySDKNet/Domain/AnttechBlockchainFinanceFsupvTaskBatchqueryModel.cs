using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvTaskBatchqueryModel : AopObject
    {
        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("fund_supv_product_code")]
        public string FundSupvProductCode { get; set; }

        /// <summary>
        /// 任务开始日期
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 管控方证件号，一般为企业社会信用编码
        /// </summary>
        [XmlElement("supervisor_id_number")]
        public string SupervisorIdNumber { get; set; }
    }
}
