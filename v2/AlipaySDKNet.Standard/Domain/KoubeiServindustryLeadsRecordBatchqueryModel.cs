using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiServindustryLeadsRecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryLeadsRecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询时间范围结束时间（客资创建时间）,不能早于查询时间范围的开始时间，查询时间范围要在三个月之内（开始和结束时间的跨度），不能超过三个月。
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 查询时间范围开始时间（客资创建时间）,不能早于2020-05-01 00:00:00
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 分页参数页码，第几页，要大于0，必须是数字
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数，每页查询数量大小，必须大于0，必须是数字，目前默认20，不能超过20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
