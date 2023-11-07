using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIssalaryDataUploadResponse.
    /// </summary>
    public class AlipayIserviceIssalaryDataUploadResponse : AopResponse
    {
        /// <summary>
        /// 操作结果描述
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
