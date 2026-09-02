using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDetailOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDetailOpenApiResponse : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("delivery_express_info")]
        [XmlArrayItem("delivery_logistics")]
        public List<DeliveryLogistics> DeliveryExpressInfo { get; set; }

        /// <summary>
        /// 预计最早发货时间
        /// </summary>
        [XmlElement("estimated_delivery_earliest_time")]
        public string EstimatedDeliveryEarliestTime { get; set; }

        /// <summary>
        /// 预计最晚发货时间
        /// </summary>
        [XmlElement("estimated_delivery_latest_time")]
        public string EstimatedDeliveryLatestTime { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("order_desc")]
        public string OrderDesc { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务编号，调用方传入的业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 订单物料数量（个）
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 对客订单状态，枚举值：AUDITING（审核中）、AUDIT_REJECT（审核拒绝）、TO_BE_SHIPPED（待发货）、SHIPPING（运输中）、RECEIVED（已签收）、NOT_RECEIVED（未签收）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板编码，订单关联的商品模板标识
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
