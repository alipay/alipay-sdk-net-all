using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapiseventhRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapiseventhRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试参数，无需关注
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }
    }
}
