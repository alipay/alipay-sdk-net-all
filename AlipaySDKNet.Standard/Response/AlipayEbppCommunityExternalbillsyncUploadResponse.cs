using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityExternalbillsyncUploadResponse.
    /// </summary>
    public class AlipayEbppCommunityExternalbillsyncUploadResponse : AopResponse
    {
        /// <summary>
        /// 失败总数
        /// </summary>
        [XmlElement("fail_count")]
        public string FailCount { get; set; }

        /// <summary>
        /// 失败列表，用于告知失败账单号和原有
        /// </summary>
        [XmlArray("fail_external_sync")]
        [XmlArrayItem("fail_external_sync")]
        public List<FailExternalSync> FailExternalSync { get; set; }

        /// <summary>
        /// 成功总数
        /// </summary>
        [XmlElement("success_count")]
        public string SuccessCount { get; set; }
    }
}
