using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitRealtimeCertifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSelleradmitRealtimeCertifyResponse : AopResponse
    {
        /// <summary>
        /// 不准入原因码
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 卖家实时准入结果
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
