using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishSpecGroup Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishSpecGroup : AopObject
    {
        /// <summary>
        /// 规格标签明细
        /// </summary>
        [XmlArray("spec_detail_list")]
        [XmlArrayItem("kbdish_spec_group_detail")]
        public List<KbdishSpecGroupDetail> SpecDetailList { get; set; }

        /// <summary>
        /// 规格组id, 热组 冷组 去冰组
        /// </summary>
        [XmlElement("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 规格组的名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }
    }
}
