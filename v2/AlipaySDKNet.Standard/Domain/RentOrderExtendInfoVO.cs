using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderExtendInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderExtendInfoVO : AopObject
    {
        /// <summary>
        /// 芝麻租赁频道联营订单标
        /// </summary>
        [XmlElement("union_rent_tag")]
        public string UnionRentTag { get; set; }
    }
}
