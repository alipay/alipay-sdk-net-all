using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountSchoolAccountConsultResponse.
    /// </summary>
    public class AlipayFundJointaccountSchoolAccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 返回学生是否加小荷包，若学生的证件号、姓名等信息不匹配则返回false
        /// </summary>
        [XmlElement("has_registered")]
        public bool HasRegistered { get; set; }

        /// <summary>
        /// 如果有对应的实体会返回实体id校内额度提醒校外额度提醒是否签约代扣
        /// </summary>
        [XmlArray("school_entity_info_list")]
        [XmlArrayItem("j_a_school_entity_info")]
        public List<JASchoolEntityInfo> SchoolEntityInfoList { get; set; }
    }
}
