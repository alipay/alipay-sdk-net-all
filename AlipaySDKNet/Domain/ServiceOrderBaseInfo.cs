using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceOrderBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceOrderBaseInfo : AopObject
    {
        /// <summary>
        /// 订购主体ID（根据 buyer_role_type 区分订购主体ID类型）
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订购主体名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 订购主体角色类型
        /// </summary>
        [XmlElement("buyer_role_type")]
        public string BuyerRoleType { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 费用子类型
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 订购单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务订购状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单时间
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
        /// 服务订购类型
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
