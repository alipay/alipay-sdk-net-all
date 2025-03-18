using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexRefSeventh Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexRefSeventh : AopObject
    {
        /// <summary>
        /// 测试数据ADD
        /// </summary>
        [XmlElement("case_1")]
        public string Case1 { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("case_2")]
        public bool Case2 { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
