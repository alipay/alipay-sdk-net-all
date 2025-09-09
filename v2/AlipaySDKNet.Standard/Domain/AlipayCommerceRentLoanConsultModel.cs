using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentLoanConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentLoanConsultModel : AopObject
    {
        /// <summary>
        /// 订单收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家用户信息
        /// </summary>
        [XmlElement("buyer_info")]
        public BuyerInfoDTO BuyerInfo { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("consult_invest_pid_list")]
        [XmlArrayItem("string")]
        public List<string> ConsultInvestPidList { get; set; }

        /// <summary>
        /// 商品详细信息
        /// </summary>
        [XmlElement("item_infos")]
        public RentItemInfoDTO ItemInfos { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 租赁价格明细信息
        /// </summary>
        [XmlElement("price_info")]
        public RentPriceInfoDTO PriceInfo { get; set; }
    }
}
