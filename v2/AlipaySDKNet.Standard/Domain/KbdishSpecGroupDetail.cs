using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishSpecGroupDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishSpecGroupDetail : AopObject
    {
        /// <summary>
        /// 规格标签id
        /// </summary>
        [XmlElement("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 规格标签的名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }
    }
}
