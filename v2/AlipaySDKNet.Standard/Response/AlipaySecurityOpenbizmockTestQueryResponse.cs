using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityOpenbizmockTestQueryResponse.
    /// </summary>
    public class AlipaySecurityOpenbizmockTestQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// test_price
        /// </summary>
        [XmlElement("mobile_number")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("out_a")]
        public RegressionPublic OutA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("para_a")]
        public string ParaA { get; set; }

        /// <summary>
        /// test_number
        /// </summary>
        [XmlElement("test_number")]
        public long TestNumber { get; set; }

        /// <summary>
        /// 测试基础描述
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("uid_openid")]
        public string UidOpenid { get; set; }
    }
}
