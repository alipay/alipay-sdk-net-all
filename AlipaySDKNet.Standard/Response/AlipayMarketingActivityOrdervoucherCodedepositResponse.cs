using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodedepositResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodedepositResponse : AopResponse
    {
        /// <summary>
        /// 导入失败的券码数量
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 导入成功的券码数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
