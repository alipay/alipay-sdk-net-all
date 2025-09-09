using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexRefFifth Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexRefFifth : AopObject
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("param_demo")]
        public string ParamDemo { get; set; }
    }
}
