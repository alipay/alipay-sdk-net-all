using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentZatSellerPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentZatSellerPublishModel : AopObject
    {
        /// <summary>
        /// 交易组件订单Id，取值租赁下单接口返回的 orderId
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// create=指定二级商户，update=更新二级商户
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 支付宝二级商户编号(间连受理商户的支付宝商户编号，直付通场景下必传)
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 二级商户smid
        /// </summary>
        [XmlElement("sub_smid")]
        public string SubSmid { get; set; }
    }
}
