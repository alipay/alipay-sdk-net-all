using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupinstanceinfoDisbandModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupinstanceinfoDisbandModel : AopObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_instance_id")]
        public string GroupInstanceId { get; set; }
    }
}
