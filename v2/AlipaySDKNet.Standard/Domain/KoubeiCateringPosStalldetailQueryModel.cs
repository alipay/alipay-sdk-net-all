using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosStalldetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStalldetailQueryModel : AopObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("stall_id")]
        public string StallId { get; set; }
    }
}
