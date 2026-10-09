using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseCompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseCompanyQueryModel : AopObject
    {
        /// <summary>
        /// 组织名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }
    }
}
