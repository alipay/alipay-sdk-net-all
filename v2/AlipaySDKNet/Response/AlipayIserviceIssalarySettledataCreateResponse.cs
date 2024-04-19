using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIssalarySettledataCreateResponse.
    /// </summary>
    public class AlipayIserviceIssalarySettledataCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作结果信息
        /// </summary>
        [XmlElement("op_msg")]
        public string OpMsg { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("op_result")]
        public bool OpResult { get; set; }
    }
}
