using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCostassetsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCostassetsQueryModel : AopObject
    {
        /// <summary>
        /// 需要消耗的福卡数量
        /// </summary>
        [XmlElement("cost_count")]
        public long CostCount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// SHOP：服气店； GAME：游戏； SQUARE：福气乐园
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
