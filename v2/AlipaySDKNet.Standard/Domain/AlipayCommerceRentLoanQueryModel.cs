using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentLoanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentLoanQueryModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识 
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 交易组件id，通过交易组件创建的order_id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
