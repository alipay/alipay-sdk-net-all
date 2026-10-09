using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodecountResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodecountResponse : AopResponse
    {
        /// <summary>
        /// 已经导入的券码数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
