using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskListQueryModel : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 出资方id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 出资方类型：品牌BRAND，零售商RETAILER，平台PLATFORM
        /// </summary>
        [XmlElement("funder_type")]
        public string FunderType { get; set; }

        /// <summary>
        /// 活动方id
        /// </summary>
        [XmlElement("organizer_id")]
        public string OrganizerId { get; set; }

        /// <summary>
        /// 活动方类型：零售商RETAILER
        /// </summary>
        [XmlElement("organizer_type")]
        public string OrganizerType { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务状态 未发布(UNPUBLISHED) 可发布(PUBLISHABLE) 未开始(NOTSTARTED) 进行中(STARTED) 暂停中(SUSPENDED) 已结束(FINISH)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
