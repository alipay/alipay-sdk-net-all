using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMemberbuyStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberbuyStatusSyncModel : AopObject
    {
        /// <summary>
        /// 淘侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 可售/不可售
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
