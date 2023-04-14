using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPrizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPrizeInfo : AopObject
    {
        /// <summary>
        /// 奖品是否能兑换
        /// </summary>
        [XmlElement("item_can_exchange")]
        public bool ItemCanExchange { get; set; }

        /// <summary>
        /// 奖品code,唯一标识
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 奖品图标链接
        /// </summary>
        [XmlElement("item_icon_url")]
        public string ItemIconUrl { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 奖品价格
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 奖品兑换需要积分数
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }
    }
}
