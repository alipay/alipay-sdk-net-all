using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadResponse.
    /// </summary>
    public class AlipayEcoRenthouseBillOrderDownloadResponse : AopResponse
    {
        /// <summary>
        /// 状态值（等级值、未授权、未知）
        /// </summary>
        [XmlElement("status_value")]
        public string StatusValue { get; set; }
    }
}
