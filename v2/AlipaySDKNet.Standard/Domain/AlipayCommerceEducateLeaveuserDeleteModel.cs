using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateLeaveuserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateLeaveuserDeleteModel : AopObject
    {
        /// <summary>
        /// 需要删除的申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 请假人花名册id
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
