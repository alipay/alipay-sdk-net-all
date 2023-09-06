using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudDevopsBaseUseResponse.
    /// </summary>
    public class AlipayCloudDevopsBaseUseResponse : AopResponse
    {
        /// <summary>
        /// 通过
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 闪退列表
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
