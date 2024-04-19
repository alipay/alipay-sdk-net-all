using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppDemoTestQueryResponse.
    /// </summary>
    public class ZhimaOpenAppDemoTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 方法
        /// </summary>
        [XmlElement("platform_a")]
        public string PlatformA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_2")]
        public string Test2 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_6")]
        public string Test6 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_id")]
        public string TestId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_id_open_id")]
        public string TestIdOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_number")]
        public string TestNumber { get; set; }
    }
}
