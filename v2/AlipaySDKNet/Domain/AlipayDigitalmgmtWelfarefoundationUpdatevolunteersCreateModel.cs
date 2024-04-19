using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtWelfarefoundationUpdatevolunteersCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtWelfarefoundationUpdatevolunteersCreateModel : AopObject
    {
        /// <summary>
        /// 租户编码
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 志愿者信息
        /// </summary>
        [XmlArray("volunteers")]
        [XmlArrayItem("add_volunteer_req")]
        public List<AddVolunteerReq> Volunteers { get; set; }
    }
}
