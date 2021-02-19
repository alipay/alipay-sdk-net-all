using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialForestSimplecertificateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialForestSimplecertificateQueryModel : AopObject
    {
        /// <summary>
        /// 年份
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
