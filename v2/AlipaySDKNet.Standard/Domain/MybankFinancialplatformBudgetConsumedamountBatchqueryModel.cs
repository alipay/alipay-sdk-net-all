using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankFinancialplatformBudgetConsumedamountBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinancialplatformBudgetConsumedamountBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务活动唯一id集合
        /// </summary>
        [XmlArray("biz_uk_ids")]
        [XmlArrayItem("string")]
        public List<string> BizUkIds { get; set; }

        /// <summary>
        /// nameSpace PURCHASE
        /// </summary>
        [XmlElement("ns")]
        public string Ns { get; set; }
    }
}
