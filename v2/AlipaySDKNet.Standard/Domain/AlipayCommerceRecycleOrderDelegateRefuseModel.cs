using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateRefuseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderDelegateRefuseModel : AopObject
    {
        /// <summary>
        /// BRAND:淘宝品牌店铺
        /// </summary>
        [XmlElement("delegate_type")]
        public string DelegateType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 请参考回收订单终止原因枚举
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 用户收货地址， 如果是商户邮寄，创单时候用户已经存入且不传入，则默认用创单的作为收货地址
        /// </summary>
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("user_area")]
        public string UserArea { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("user_city")]
        public string UserCity { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 1241414142
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("user_province")]
        public string UserProvince { get; set; }
    }
}
