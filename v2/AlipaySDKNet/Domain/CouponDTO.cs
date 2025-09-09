using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CouponDTO : AopObject
    {
        /// <summary>
        /// 优惠券ID
        /// </summary>
        [XmlElement("prize_instance_id")]
        public string PrizeInstanceId { get; set; }
    }
}
