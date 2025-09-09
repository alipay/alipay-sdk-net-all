using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyStaffSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyStaffSaveModel : AopObject
    {
        /// <summary>
        /// 执行动作 新增：ADD 更新：UPDATE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("staff_info_v_o")]
        public List<StaffInfoVO> List { get; set; }
    }
}
