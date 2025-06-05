using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillOperationConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWaybillOperationConfirmModel : AopObject
    {
        /// <summary>
        /// 接口调用方的渠道名称，由支付宝分配
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 操作运单范围
        /// </summary>
        [XmlElement("channel_waybill_operation_scope")]
        public string ChannelWaybillOperationScope { get; set; }

        /// <summary>
        /// 身份标识
        /// </summary>
        [XmlElement("identity_tag")]
        public string IdentityTag { get; set; }

        /// <summary>
        /// 身份类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 仓节点唯一id
        /// </summary>
        [XmlElement("lbx")]
        public string Lbx { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识 当前字段已废弃(文档升级，请使用identity_tag与identity_type)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 二方外部订单id
        /// </summary>
        [XmlElement("outbiz_order_id")]
        public string OutbizOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 当前字段已废弃(文档升级，请使用identity_tag与identity_type)
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
