using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataOpenapisdkRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataOpenapisdkRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("input_param_01")]
        public string InputParam01 { get; set; }

        /// <summary>
        /// 引用复杂类型
        /// </summary>
        [XmlElement("ref_params")]
        public RainyComplexTypesTheFirst RefParams { get; set; }
    }
}
