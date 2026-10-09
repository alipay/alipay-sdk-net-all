using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindResponse.
    /// </summary>
    public class KoubeiMarketingMallTradeBindResponse : AopResponse
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
