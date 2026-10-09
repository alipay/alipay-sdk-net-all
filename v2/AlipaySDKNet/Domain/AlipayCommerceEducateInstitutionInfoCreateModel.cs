using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInstitutionInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateInstitutionInfoCreateModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 关联高校运动学校编号
        /// </summary>
        [XmlElement("ref_inst_code")]
        public string RefInstCode { get; set; }
    }
}
