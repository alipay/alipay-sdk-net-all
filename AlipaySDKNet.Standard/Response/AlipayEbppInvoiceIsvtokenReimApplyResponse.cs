using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceIsvtokenReimApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceIsvtokenReimApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝分配给报销软件的授权token，当前设置有效时间为20分钟
        /// </summary>
        [XmlElement("isv_token")]
        public string IsvToken { get; set; }

        /// <summary>
        /// 该次请求的唯一标志，当前设置有效时间为20分钟
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
