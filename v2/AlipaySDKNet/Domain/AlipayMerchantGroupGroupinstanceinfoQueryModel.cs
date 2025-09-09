using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupinstanceinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupinstanceinfoQueryModel : AopObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_instance_id")]
        public string GroupInstanceId { get; set; }

        /// <summary>
        /// 是否需要返回群成员
        /// </summary>
        [XmlElement("need_member")]
        public bool NeedMember { get; set; }
    }
}
