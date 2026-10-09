using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcinstitutionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthPbcinstitutionQueryModel : AopObject
    {
        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
