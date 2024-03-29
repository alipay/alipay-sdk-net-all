using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyOrderData Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyOrderData : AopObject
    {
        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [XmlElement("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [XmlElement("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 标识老工单
        /// </summary>
        [XmlElement("is_old_data")]
        public bool IsOldData { get; set; }

        /// <summary>
        /// 是不是最新的工单
        /// </summary>
        [XmlElement("latest")]
        public bool Latest { get; set; }

        /// <summary>
        /// 服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效
        /// </summary>
        [XmlElement("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 审核提效部分剔除数据的信息
        /// </summary>
        [XmlArray("part_agree_info")]
        [XmlArrayItem("search_part_agree_info")]
        public List<SearchPartAgreeInfo> PartAgreeInfo { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 申请状态 AGREE、REJECT、EDIT、AUDIT
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子服务名称
        /// </summary>
        [XmlElement("sub_service_name")]
        public string SubServiceName { get; set; }
    }
}
