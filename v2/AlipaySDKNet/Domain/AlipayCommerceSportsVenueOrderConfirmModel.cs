using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueOrderConfirmModel : AopObject
    {
        /// <summary>
        /// 订单确认描述
        /// </summary>
        [XmlElement("confirm_desc")]
        public string ConfirmDesc { get; set; }

        /// <summary>
        /// 订单确认状态 succ - 确认成功 fail - 确认失败
        /// </summary>
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单商品信息列表
        /// </summary>
        [XmlArray("product_group_list")]
        [XmlArrayItem("product_group")]
        public List<ProductGroup> ProductGroupList { get; set; }

        /// <summary>
        /// 订单付款总金额(单位：元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
