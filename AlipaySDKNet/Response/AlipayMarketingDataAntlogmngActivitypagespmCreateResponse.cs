using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataAntlogmngActivitypagespmCreateResponse.
    /// </summary>
    public class AlipayMarketingDataAntlogmngActivitypagespmCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请是否成功
        /// </summary>
        [XmlElement("issuc")]
        public bool Issuc { get; set; }

        /// <summary>
        /// 描述业务状态
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
