using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchAbilityOrderData Data Structure.
    /// </summary>
    [Serializable]
    public class SearchAbilityOrderData : AopObject
    {
        /// <summary>
        /// 申请单类型
        /// </summary>
        [XmlElement("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序状态 ON_LINE、OFF_LINE
        /// </summary>
        [XmlElement("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 申请状态 AGREE、REJECT、EDIT、AUDIT
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// bizId 为品牌box的boxID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 品牌box的上下架状态 ONLINE OFFLINE
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [XmlElement("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 二级服务信息
        /// </summary>
        [XmlArray("children")]
        [XmlArrayItem("search_ability_order_info_open_api")]
        public List<SearchAbilityOrderInfoOpenApi> Children { get; set; }

        /// <summary>
        /// 二级服务的唯一标识
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 服务的唯一标识（优先使用serviceCode可忽略）
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否是老工单
        /// </summary>
        [XmlElement("is_old_data")]
        public string IsOldData { get; set; }

        /// <summary>
        /// 服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效
        /// </summary>
        [XmlElement("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 服务的可见性状态
        /// </summary>
        [XmlElement("open_status")]
        public bool OpenStatus { get; set; }

        /// <summary>
        /// 下架操作者
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 场景码
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
        /// 子功能描述
        /// </summary>
        [XmlElement("sub_service_desc")]
        public string SubServiceDesc { get; set; }

        /// <summary>
        /// 子功能名称
        /// </summary>
        [XmlElement("sub_service_name")]
        public string SubServiceName { get; set; }
    }
}
