using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceProductInfo : AopObject
    {
        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 服务的费用子类型
        /// </summary>
        [XmlElement("service_expense_sub_type")]
        public string ServiceExpenseSubType { get; set; }

        /// <summary>
        /// 服务费用子类型名称
        /// </summary>
        [XmlElement("service_expense_sub_type_name")]
        public string ServiceExpenseSubTypeName { get; set; }

        /// <summary>
        /// 服务产品id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务是否需要订购
        /// </summary>
        [XmlElement("service_order_model")]
        public string ServiceOrderModel { get; set; }

        /// <summary>
        /// 服务亮点
        /// </summary>
        [XmlElement("service_point")]
        public string ServicePoint { get; set; }

        /// <summary>
        /// 服务预览url
        /// </summary>
        [XmlArray("service_preview_urls")]
        [XmlArrayItem("service_product_preview_info")]
        public List<ServiceProductPreviewInfo> ServicePreviewUrls { get; set; }

        /// <summary>
        /// 服务可提供能力
        /// </summary>
        [XmlArray("service_product_ability_info")]
        [XmlArrayItem("service_product_ability_info")]
        public List<ServiceProductAbilityInfo> ServiceProductAbilityInfo { get; set; }

        /// <summary>
        /// 服务发布方id
        /// </summary>
        [XmlElement("service_publish_id")]
        public string ServicePublishId { get; set; }

        /// <summary>
        /// 服务发布方名称
        /// </summary>
        [XmlElement("service_publish_name")]
        public string ServicePublishName { get; set; }

        /// <summary>
        /// 服务发布方类型
        /// </summary>
        [XmlElement("service_publish_type")]
        public string ServicePublishType { get; set; }

        /// <summary>
        /// 服务签约类型
        /// </summary>
        [XmlElement("service_sign_type")]
        public string ServiceSignType { get; set; }

        /// <summary>
        /// 服务状态
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
