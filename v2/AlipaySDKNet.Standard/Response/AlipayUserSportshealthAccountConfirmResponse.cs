using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportshealthAccountConfirmResponse.
    /// </summary>
    public class AlipayUserSportshealthAccountConfirmResponse : AopResponse
    {
        /// <summary>
        /// 运动币账户支付流水号
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }
    }
}
