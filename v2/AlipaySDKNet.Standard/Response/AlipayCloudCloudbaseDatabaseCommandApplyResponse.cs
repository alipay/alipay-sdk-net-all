using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseCommandApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseCommandApplyResponse : AopResponse
    {
        /// <summary>
        /// 执行结果，JSON格式
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
