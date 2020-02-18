using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataRiskRtopobtsregQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataRiskRtopobtsregQueryModel : AopObject
    {
        /// <summary>
        /// rowkeys+不需要唯一+鹰眼项目，通过open api接口查询舆情
        /// </summary>
        [XmlElement("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
