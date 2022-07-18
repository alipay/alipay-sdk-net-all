using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasPutplanModifyModel : AopObject
    {
        /// <summary>
        /// 自由页面活动链接
        /// </summary>
        [XmlElement("activity_page")]
        public string ActivityPage { get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [XmlElement("bill_way")]
        public string BillWay { get; set; }

        /// <summary>
        /// 渠道 id
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

        /// <summary>
        /// 人群 id 列表
        /// </summary>
        [XmlElement("crowd_ids")]
        public string CrowdIds { get; set; }

        /// <summary>
        /// 自定义页面地址链接
        /// </summary>
        [XmlElement("customize_page")]
        public string CustomizePage { get; set; }

        /// <summary>
        /// 投放计划结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 主键 id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 修改人 id
        /// </summary>
        [XmlElement("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        [XmlElement("modifier_name")]
        public string ModifierName { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页面类型
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 投放计划开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 运营增长活动 id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 租户 code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
