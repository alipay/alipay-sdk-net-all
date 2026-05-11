using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderChangedExtendInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderChangedExtendInfoVO : AopObject
    {
        /// <summary>
        /// 租赁派单ID，唯一标识一次派单请求
        /// </summary>
        [XmlElement("rent_dispatch_id")]
        public string RentDispatchId { get; set; }
    }
}
