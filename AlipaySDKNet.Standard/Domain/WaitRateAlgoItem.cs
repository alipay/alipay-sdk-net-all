using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WaitRateAlgoItem Data Structure.
    /// </summary>
    [Serializable]
    public class WaitRateAlgoItem : AopObject
    {
        /// <summary>
        /// 待评价算法打分itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 算法打分分值
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
