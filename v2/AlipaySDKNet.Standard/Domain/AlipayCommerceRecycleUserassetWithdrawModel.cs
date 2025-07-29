using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleUserassetWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleUserassetWithdrawModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 提现场景下的订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔提现请求，商户需保证该订单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
