using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexTypeWeakRefFifth Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexTypeWeakRefFifth : AopObject
    {
        /// <summary>
        /// demo——date的测试数据
        /// </summary>
        [XmlElement("demo_date")]
        public string DemoDate { get; set; }
    }
}
