using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataOpenapipageRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataOpenapipageRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 字符串
        /// </summary>
        [XmlElement("input_param_01")]
        public string InputParam01 { get; set; }
    }
}
