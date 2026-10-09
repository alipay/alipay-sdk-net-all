using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSemesterInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSemesterInfoBatchqueryModel : AopObject
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
        /// 每页数量，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 学期ID
        /// </summary>
        [XmlElement("semester_id")]
        public string SemesterId { get; set; }

        /// <summary>
        /// 学期名称
        /// </summary>
        [XmlElement("semester_name")]
        public string SemesterName { get; set; }
    }
}
