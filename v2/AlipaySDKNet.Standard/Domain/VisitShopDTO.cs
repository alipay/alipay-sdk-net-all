using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VisitShopDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VisitShopDTO : AopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 已打卡次数
        /// </summary>
        [XmlElement("check_times")]
        public long CheckTimes { get; set; }

        /// <summary>
        /// 是否打卡达标
        /// </summary>
        [XmlElement("finish")]
        public bool Finish { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 2024xxx
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
