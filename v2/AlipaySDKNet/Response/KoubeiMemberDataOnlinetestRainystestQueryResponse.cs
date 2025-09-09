using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMemberDataOnlinetestRainystestQueryResponse.
    /// </summary>
    public class KoubeiMemberDataOnlinetestRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("demo_case")]
        public bool DemoCase { get; set; }
    }
}
