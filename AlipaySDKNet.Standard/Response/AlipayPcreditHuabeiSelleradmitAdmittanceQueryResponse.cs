using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitAdmittanceQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSelleradmitAdmittanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 不准入原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求场景，id集合，拼接
        /// </summary>
        [XmlElement("request_key")]
        public string RequestKey { get; set; }
    }
}
