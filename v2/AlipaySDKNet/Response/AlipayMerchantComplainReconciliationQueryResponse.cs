using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationQueryResponse.
    /// </summary>
    public class AlipayMerchantComplainReconciliationQueryResponse : AopResponse
    {
        /// <summary>
        /// 一些不影响开通12315一键和解流程，但是有问题的地方
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 间连/直连商家开通一键和解功能过程中的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
