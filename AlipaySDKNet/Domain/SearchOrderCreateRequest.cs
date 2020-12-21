using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderCreateRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderCreateRequest : AopObject
    {
        /// <summary>
        /// 创建方式
        /// </summary>
        [XmlElement("access_mode")]
        public string AccessMode { get; set; }

        /// <summary>
        /// 搜索直达类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [XmlElement("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 处理动作 on off
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 小程序名字
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 基础信息申请单提报详情
        /// </summary>
        [XmlElement("base_items")]
        public SearchBaseItems BaseItems { get; set; }

        /// <summary>
        /// bizId 为品牌box的boxID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 品牌box降级
        /// </summary>
        [XmlElement("brand_down_grade")]
        public bool BrandDownGrade { get; set; }

        /// <summary>
        /// 品牌box申请单提报详情
        /// </summary>
        [XmlElement("brand_items")]
        public SearchBrandItems BrandItems { get; set; }

        /// <summary>
        /// 申请单创建来源类型
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 二级服务唯一标识
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("descprise")]
        public string Descprise { get; set; }

        /// <summary>
        /// 是否为草稿态
        /// </summary>
        [XmlElement("is_draft")]
        public bool IsDraft { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("key_words")]
        public string KeyWords { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 父工单id
        /// </summary>
        [XmlElement("ref_apply_id")]
        public string RefApplyId { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

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
        /// 服务申请单提报信息详情
        /// </summary>
        [XmlElement("service_items")]
        public SearchServiceItems ServiceItems { get; set; }

        /// <summary>
        /// 服务的类型 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 搜索模板id 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 搜索模板类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
