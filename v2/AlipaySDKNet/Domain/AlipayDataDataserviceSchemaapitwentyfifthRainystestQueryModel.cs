using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapitwentyfifthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapitwentyfifthRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 数字类型的参数
        /// </summary>
        [XmlElement("demo_num")]
        public long DemoNum { get; set; }
    }
}
