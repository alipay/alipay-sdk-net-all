using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryTrafficFacecertifyresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryTrafficFacecertifyresultQueryModel : AopObject
    {
        /// <summary>
        /// 12123app传入的校验id
        /// </summary>
        [XmlElement("check_id")]
        public string CheckId { get; set; }
    }
}
