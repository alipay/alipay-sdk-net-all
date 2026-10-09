using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityPayeeinfoCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityPayeeinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 进件状态。  枚举值： SUCCESS：进件成功  APPLY：已申请进件，处理中.
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
