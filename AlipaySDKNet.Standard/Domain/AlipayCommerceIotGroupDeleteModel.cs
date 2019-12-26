using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotGroupDeleteModel : AopObject
    {
        /// <summary>
        /// 需要删除的分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
