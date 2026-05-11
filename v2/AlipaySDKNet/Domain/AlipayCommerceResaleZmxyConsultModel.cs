using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleZmxyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleZmxyConsultModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item_info_list")]
        public ResaleOrderItemVO ItemInfoList { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额，单位元，用于风控评估
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 3C数码：DIGITAL 卡券：VOUCHER
        /// </summary>
        [XmlElement("service_category")]
        public string ServiceCategory { get; set; }

        /// <summary>
        /// 通过checkBeforeOrder获取
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
