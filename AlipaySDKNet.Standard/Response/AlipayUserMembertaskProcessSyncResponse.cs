using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMembertaskProcessSyncResponse.
    /// </summary>
    public class AlipayUserMembertaskProcessSyncResponse : AopResponse
    {
        /// <summary>
        /// 任务推进结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 任务推进结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 异常是否可重试
        /// </summary>
        [XmlElement("retriable")]
        public string Retriable { get; set; }

        /// <summary>
        /// 任务推进调用结果，不代表推进实际成功，推进是否成功由内部保证，外围无需关心
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
