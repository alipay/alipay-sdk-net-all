using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePeriodInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePeriodInfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 分页页数，默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量，默认为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 课时ID
        /// </summary>
        [XmlElement("period_id")]
        public string PeriodId { get; set; }

        /// <summary>
        /// 课时名称
        /// </summary>
        [XmlElement("period_name")]
        public string PeriodName { get; set; }
    }
}
