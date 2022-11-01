using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportshealthAccountFreezeResponse.
    /// </summary>
    public class AlipayUserSportshealthAccountFreezeResponse : AopResponse
    {
        /// <summary>
        /// 运动币账户支付流水号,运动侧作为事务id
        /// </summary>
        [XmlElement("pay_order_no")]
        public string PayOrderNo { get; set; }
    }
}
