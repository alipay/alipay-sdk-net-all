using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserWufufukaAliyunExchangeResponse.
    /// </summary>
    public class AlipayUserWufufukaAliyunExchangeResponse : AopResponse
    {
        /// <summary>
        /// 是否需要回退+否+业务方判断是否回退+true/false+支付宝判断+失败情况判断
        /// </summary>
        [XmlElement("refund_flag")]
        public bool RefundFlag { get; set; }
    }
}
