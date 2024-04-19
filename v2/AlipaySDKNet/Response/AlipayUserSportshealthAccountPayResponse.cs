using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportshealthAccountPayResponse.
    /// </summary>
    public class AlipayUserSportshealthAccountPayResponse : AopResponse
    {
        /// <summary>
        /// 运动币账户支付流水号
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }
    }
}
