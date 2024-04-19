using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageDetailsQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageDetailsQueryResponse : AopResponse
    {
        /// <summary>
        /// 短信发送明细。
        /// </summary>
        [XmlArray("sms_send_detail")]
        [XmlArrayItem("sms_send_detail")]
        public List<SmsSendDetail> SmsSendDetail { get; set; }

        /// <summary>
        /// 短信发送成功条数
        /// </summary>
        [XmlElement("success_count")]
        public string SuccessCount { get; set; }

        /// <summary>
        /// 短信发送总条数。
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
