using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderAftersaleCreateModel : AopObject
    {
        /// <summary>
        /// 退换商品的信息
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("aftersale_item_info_d_t_o")]
        public List<AftersaleItemInfoDTO> ItemInfos { get; set; }

        /// <summary>
        /// 用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家自定义售后ID
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。 order_id、out_order_id，二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 商家小程序该售后单的页面path，不存在则使用订单path
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 售后单退款金额，单位：元，精确到小数点后两位。发起实物商品的售后时需要传入
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户的uid（与openId二选一）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
