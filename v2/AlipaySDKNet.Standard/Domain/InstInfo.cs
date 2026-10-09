using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstInfo : AopObject
    {
        /// <summary>
        /// 机构号
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// ISV在机构测的唯一编号
        /// </summary>
        [XmlElement("isv_inst_no")]
        public string IsvInstNo { get; set; }
    }
}
