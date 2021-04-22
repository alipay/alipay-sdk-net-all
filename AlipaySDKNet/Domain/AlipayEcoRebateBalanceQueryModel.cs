using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoRebateBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRebateBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 商户侧唯一商品id，查询该商品的返利信息。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户支付宝唯一标识，2088开头。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
