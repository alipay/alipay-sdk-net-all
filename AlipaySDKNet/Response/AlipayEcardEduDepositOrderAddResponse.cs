using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcardEduDepositOrderAddResponse.
    /// </summary>
    public class AlipayEcardEduDepositOrderAddResponse : AopResponse
    {
        /// <summary>
        /// 支付申请流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
