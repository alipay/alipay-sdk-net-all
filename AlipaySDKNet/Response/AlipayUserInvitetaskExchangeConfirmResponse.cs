using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConfirmResponse.
    /// </summary>
    public class AlipayUserInvitetaskExchangeConfirmResponse : AopResponse
    {
        /// <summary>
        /// true-确认成功，可以进行下一步的代扣、发货  false-确认失败，不要进行下一步代扣
        /// </summary>
        [XmlElement("confirm_result")]
        public bool ConfirmResult { get; set; }
    }
}
