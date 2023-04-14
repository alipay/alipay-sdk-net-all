using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceBaseInfo : AopObject
    {
        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 费用类型描述
        /// </summary>
        [XmlElement("expense_type_desc")]
        public string ExpenseTypeDesc { get; set; }

        /// <summary>
        /// 费用类型子类
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 费用类型子类描述
        /// </summary>
        [XmlElement("expense_type_sub_category_desc")]
        public string ExpenseTypeSubCategoryDesc { get; set; }

        /// <summary>
        /// 服务订购时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 服务选择关联的服务ID
        /// </summary>
        [XmlElement("related_service_id")]
        public string RelatedServiceId { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务订购模式
        /// </summary>
        [XmlElement("service_order_mode")]
        public string ServiceOrderMode { get; set; }

        /// <summary>
        /// 服务提供方ID
        /// </summary>
        [XmlElement("service_provider_id")]
        public string ServiceProviderId { get; set; }

        /// <summary>
        /// 服务提供方名称
        /// </summary>
        [XmlElement("service_provider_name")]
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
