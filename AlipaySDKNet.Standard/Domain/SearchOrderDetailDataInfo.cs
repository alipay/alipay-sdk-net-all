using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderDetailDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderDetailDataInfo : AopObject
    {
        /// <summary>
        /// 申请单类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [XmlElement("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序类目名
        /// </summary>
        [XmlElement("app_category")]
        public string AppCategory { get; set; }

        /// <summary>
        /// 小程序图标
        /// </summary>
        [XmlElement("app_icon")]
        public string AppIcon { get; set; }

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
        /// 小程序id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [XmlElement("base_order_status")]
        public OrderStatusData BaseOrderStatus { get; set; }

        /// <summary>
        /// bizid 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 服务box状态
        /// </summary>
        [XmlElement("box_order_status")]
        public OrderStatusData BoxOrderStatus { get; set; }

        /// <summary>
        /// 上下架状态
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [XmlElement("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 品牌box状态
        /// </summary>
        [XmlElement("brandbox_orderstatus")]
        public OrderStatusData BrandboxOrderstatus { get; set; }

        /// <summary>
        /// 是否可修改关键词
        /// </summary>
        [XmlElement("can_modify_keyword")]
        public bool CanModifyKeyword { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 基础工单详情信息
        /// </summary>
        [XmlElement("detail_base_items")]
        public SearchOrderDetailDataBaseItems DetailBaseItems { get; set; }

        /// <summary>
        /// 品牌工单详情数据
        /// </summary>
        [XmlElement("detail_brand_items")]
        public SearchOrderDetailDataBrandItems DetailBrandItems { get; set; }

        /// <summary>
        /// 服务工单数据详情
        /// </summary>
        [XmlElement("detail_service_items")]
        public SearchOrderDetailDataServiceItems DetailServiceItems { get; set; }

        /// <summary>
        /// 最终状态
        /// </summary>
        [XmlElement("final_status")]
        public string FinalStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("gmtmodified")]
        public string Gmtmodified { get; set; }

        /// <summary>
        /// 关键词的修改时间
        /// </summary>
        [XmlElement("keyword_gmt_modified")]
        public string KeywordGmtModified { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 操作人员类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 查询服务提供者生态类型 一二三方 1 | 2 | 3
        /// </summary>
        [XmlElement("partner_type")]
        public string PartnerType { get; set; }

        /// <summary>
        /// 驳回节点
        /// </summary>
        [XmlElement("reject_node")]
        public string RejectNode { get; set; }

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
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
