using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDiscountPhonePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDiscountPhonePayModel : AopObject
    {
        /// <summary>
        /// 下单用户的Ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 用户进行充值所选择的面额
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 支付宝侧的商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商家端自己的订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商品的价格(元)
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 支付宝侧分配场景码，用于风控限制和商品查询
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商家端的下单来源，非必填
        /// </summary>
        [XmlElement("sub_source")]
        public string SubSource { get; set; }
    }
}
