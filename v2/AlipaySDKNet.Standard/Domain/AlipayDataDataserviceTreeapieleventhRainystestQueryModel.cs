using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceTreeapieleventhRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceTreeapieleventhRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }
    }
}
