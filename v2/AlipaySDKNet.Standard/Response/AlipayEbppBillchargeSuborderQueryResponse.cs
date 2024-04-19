using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillchargeSuborderQueryResponse.
    /// </summary>
    public class AlipayEbppBillchargeSuborderQueryResponse : AopResponse
    {
        /// <summary>
        /// 状态 I-等待付款 P-已支付 C-单据关闭  F-失败  S-成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
