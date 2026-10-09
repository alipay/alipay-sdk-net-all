using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGffundStandardvoucherBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGffundStandardvoucherBatchqueryModel : AopObject
    {
        /// <summary>
        /// 标准流水查询请求体
        /// </summary>
        [XmlElement("standard_voucher_multiple_condition_query_request")]
        public StandardVoucherMultipleConditionQueryRequest StandardVoucherMultipleConditionQueryRequest { get; set; }
    }
}
