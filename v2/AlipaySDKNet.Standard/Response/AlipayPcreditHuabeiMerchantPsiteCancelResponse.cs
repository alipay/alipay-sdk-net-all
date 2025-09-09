using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantPsiteCancelResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantPsiteCancelResponse : AopResponse
    {
        /// <summary>
        /// 是否取消报名成功
        /// </summary>
        [XmlElement("has_cancel")]
        public bool HasCancel { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
