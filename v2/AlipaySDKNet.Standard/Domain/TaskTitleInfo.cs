using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskTitleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskTitleInfo : AopObject
    {
        /// <summary>
        /// 剩余积分数，积分兑现金10:1
        /// </summary>
        [XmlElement("remain_point_amount")]
        public long RemainPointAmount { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
