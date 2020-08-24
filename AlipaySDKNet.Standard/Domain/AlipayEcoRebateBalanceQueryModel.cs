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
        /// 商户侧唯一商品id，查询商品的返利信息
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
