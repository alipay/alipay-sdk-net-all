using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectCollectionListDataTradeSummary Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectCollectionListDataTradeSummary : AopObject
    {
        /// <summary>
        /// 当日日期
        /// </summary>
        [XmlElement("date_time")]
        public string DateTime { get; set; }

        /// <summary>
        /// 当日累计退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 当日收款累计金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 当日收款累计笔数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
