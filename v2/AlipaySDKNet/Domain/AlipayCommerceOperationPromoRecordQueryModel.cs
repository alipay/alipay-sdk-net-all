using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoRecordQueryModel : AopObject
    {
        /// <summary>
        /// 活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询数据
        /// </summary>
        [XmlElement("query_data")]
        public string QueryData { get; set; }

        /// <summary>
        /// 主体ID
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
