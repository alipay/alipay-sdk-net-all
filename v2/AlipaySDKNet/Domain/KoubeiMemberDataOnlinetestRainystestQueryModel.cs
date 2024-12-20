using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMemberDataOnlinetestRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataOnlinetestRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("demo_cs")]
        public string DemoCs { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("demo_cs_2")]
        public string DemoCs2 { get; set; }
    }
}
