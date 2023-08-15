using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplayleftstatiQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplayleftstatiQueryResponse : AopResponse
    {
        /// <summary>
        /// 参与国家数
        /// </summary>
        [XmlElement("country_cnt")]
        public long CountryCnt { get; set; }

        /// <summary>
        /// 国外火炬传递平台数
        /// </summary>
        [XmlElement("foreign_platform")]
        public string ForeignPlatform { get; set; }

        /// <summary>
        /// 国外火炬传递平台数
        /// </summary>
        [XmlElement("foreign_platform_cnt")]
        public long ForeignPlatformCnt { get; set; }

        /// <summary>
        /// 国内火炬传递平台
        /// </summary>
        [XmlElement("internal_platform")]
        public string InternalPlatform { get; set; }

        /// <summary>
        /// 国内火炬传递平台数
        /// </summary>
        [XmlElement("internal_platform_cnt")]
        public long InternalPlatformCnt { get; set; }
    }
}
