using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapithirdRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapithirdRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }
    }
}
