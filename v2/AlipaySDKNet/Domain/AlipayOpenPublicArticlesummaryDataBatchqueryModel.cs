using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicArticlesummaryDataBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicArticlesummaryDataBatchqueryModel : AopObject
    {
        /// <summary>
        /// 数据开始日期，时间格式为 "yyyyMMdd" 。
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 数据结束日期，时间格式为"yyyyMMdd"。查询数据开始日期/结束日期时间跨度最大30天。
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }
    }
}
