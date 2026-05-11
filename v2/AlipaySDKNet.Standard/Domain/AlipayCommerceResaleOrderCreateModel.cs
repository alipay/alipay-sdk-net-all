using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderCreateModel : AopObject
    {
        /// <summary>
        /// 收货地址信息，邮寄方式需要输入
        /// </summary>
        [XmlElement("address_info")]
        public ResaleAddressVO AddressInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("resale_order_item_v_o")]
        public List<ResaleOrderItemVO> ItemInfoList { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单详情地址
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("order_memo")]
        public string OrderMemo { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商家订单编号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 3C：DIGITAL 卡券：VOUCHER
        /// </summary>
        [XmlElement("service_category")]
        public string ServiceCategory { get; set; }

        /// <summary>
        /// 小程序使用checkBeforeOrder()获取
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
