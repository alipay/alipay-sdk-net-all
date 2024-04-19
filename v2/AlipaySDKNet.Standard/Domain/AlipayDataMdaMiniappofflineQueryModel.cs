using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataMdaMiniappofflineQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataMdaMiniappofflineQueryModel : AopObject
    {
        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("use_pass")]
        public string UsePass { get; set; }
    }
}
