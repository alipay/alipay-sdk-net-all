using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardAuthQueryModel : AopObject
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("ins_code")]
        public string InsCode { get; set; }

        /// <summary>
        /// 持卡人与当前用户的关系
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }
    }
}
