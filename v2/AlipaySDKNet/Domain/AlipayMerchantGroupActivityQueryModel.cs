using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupActivityQueryModel : AopObject
    {
        /// <summary>
        /// 商家群活动id
        /// </summary>
        [XmlElement("group_activity_id")]
        public string GroupActivityId { get; set; }
    }
}
