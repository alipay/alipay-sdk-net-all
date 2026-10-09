using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasSyncSingledataSendResponse.
    /// </summary>
    public class AlipayMsaasSyncSingledataSendResponse : AopResponse
    {
        /// <summary>
        /// SYNC内部业务数据ID
        /// </summary>
        [XmlElement("oplog_id")]
        public string OplogId { get; set; }

        /// <summary>
        /// 返回结果代码
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回结果含义
        /// </summary>
        [XmlElement("return_reason")]
        public string ReturnReason { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
