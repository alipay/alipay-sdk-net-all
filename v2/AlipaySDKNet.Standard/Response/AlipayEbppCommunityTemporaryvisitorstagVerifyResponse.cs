using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityTemporaryvisitorstagVerifyResponse.
    /// </summary>
    public class AlipayEbppCommunityTemporaryvisitorstagVerifyResponse : AopResponse
    {
        /// <summary>
        /// 认证平台链接列表
        /// </summary>
        [XmlArray("certify_platform_info_list")]
        [XmlArrayItem("certify_platform_info")]
        public List<CertifyPlatformInfo> CertifyPlatformInfoList { get; set; }

        /// <summary>
        /// 核验结果 1 为通过 0 为核验失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
