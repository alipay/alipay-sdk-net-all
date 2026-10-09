using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockVerifyReportSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockVerifyReportSyncModel : AopObject
    {
        /// <summary>
        /// 核对记录列表
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("stock_verify_record")]
        public List<StockVerifyRecord> RecordList { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
