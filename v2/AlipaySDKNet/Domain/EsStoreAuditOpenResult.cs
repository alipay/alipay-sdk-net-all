using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EsStoreAuditOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class EsStoreAuditOpenResult : AopObject
    {
        /// <summary>
        /// 直付通申请单ID(标准进件返回)
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 直付通进件申请单订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型：SETTLE_CREATE 创建结算信息 SETTLE_MODIFY 修改结算信息
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 直付通审核状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
