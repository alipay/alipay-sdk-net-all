using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoAwardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoAwardQueryModel : AopObject
    {
        /// <summary>
        /// 活动编码，点餐B侧激励活动，编码固定
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 查询截止时间（时间跨度31天以内）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，默认值20，最大值100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询起始时间（时间跨度31天以内）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 主体ID，参考报名接口返回的subject_id
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 主体类型，参考报名接口返回的subject_type
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
