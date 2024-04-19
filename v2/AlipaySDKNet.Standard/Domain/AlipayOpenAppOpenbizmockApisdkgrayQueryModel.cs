using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockApisdkgrayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenbizmockApisdkgrayQueryModel : AopObject
    {
        /// <summary>
        /// 测试接口，参数随便配置
        /// </summary>
        [XmlElement("input_param")]
        public string InputParam { get; set; }
    }
}
