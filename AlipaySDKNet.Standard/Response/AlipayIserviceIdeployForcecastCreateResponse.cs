using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIdeployForcecastCreateResponse.
    /// </summary>
    public class AlipayIserviceIdeployForcecastCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("op_result")]
        public bool OpResult { get; set; }

        /// <summary>
        /// 操作结果提示
        /// </summary>
        [XmlElement("op_result_msg")]
        public string OpResultMsg { get; set; }
    }
}
