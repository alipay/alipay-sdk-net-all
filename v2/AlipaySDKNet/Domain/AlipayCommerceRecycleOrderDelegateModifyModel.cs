using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderDelegateModifyModel : AopObject
    {
        /// <summary>
        /// 淘宝品牌店铺：BRAND
        /// </summary>
        [XmlElement("delegate_type")]
        public string DelegateType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户收货地址
        /// </summary>
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 国家标准区域编码
        /// </summary>
        [XmlElement("user_area")]
        public string UserArea { get; set; }

        /// <summary>
        /// 国家标准城市编码
        /// </summary>
        [XmlElement("user_city")]
        public string UserCity { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }

        /// <summary>
        /// 国家标准省份编码
        /// </summary>
        [XmlElement("user_province")]
        public string UserProvince { get; set; }
    }
}
