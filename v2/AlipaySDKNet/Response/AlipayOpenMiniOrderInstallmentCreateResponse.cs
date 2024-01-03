using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderInstallmentCreateResponse.
    /// </summary>
    public class AlipayOpenMiniOrderInstallmentCreateResponse : AopResponse
    {
        /// <summary>
        /// 分期单号。在代扣等场景下使用
        /// </summary>
        [XmlElement("installment_order_id")]
        public string InstallmentOrderId { get; set; }
    }
}
