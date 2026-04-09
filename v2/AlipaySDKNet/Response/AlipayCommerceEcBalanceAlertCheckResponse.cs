using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcBalanceAlertCheckResponse.
    /// </summary>
    public class AlipayCommerceEcBalanceAlertCheckResponse : AopResponse
    {
        /// <summary>
        /// 余额是否充足（true: 充足, false: 不充足）
        /// </summary>
        [XmlElement("sufficient")]
        public bool Sufficient { get; set; }
    }
}
