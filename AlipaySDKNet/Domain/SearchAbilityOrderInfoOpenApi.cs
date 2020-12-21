using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchAbilityOrderInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class SearchAbilityOrderInfoOpenApi : AopObject
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
        /// 小程序状态
        /// </summary>
        [XmlElement("app_status")]
        public string AppStatus { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 运营申请单详情biz_id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 上架状态
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌模板id
        /// </summary>
        [XmlElement("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 二级服务唯一标识
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否老工单
        /// </summary>
        [XmlElement("is_old_data")]
        public bool IsOldData { get; set; }

        /// <summary>
        /// 服务主状态
        /// </summary>
        [XmlElement("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 小程序可见性
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
        /// 小程序id
        /// </summary>
        [XmlElement("search_app_id")]
        public string SearchAppId { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [XmlElement("sepc_code")]
        public string SepcCode { get; set; }

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
