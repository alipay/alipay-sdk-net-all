using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPaymrchdataQrcodeCreateResponse.
    /// </summary>
    public class AlipayMerchantPaymrchdataQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 经营码开通结果
        /// </summary>
        [XmlElement("open_result")]
        public bool OpenResult { get; set; }

        /// <summary>
        /// 表示经营码开通的单据号
        /// </summary>
        [XmlElement("qrcode_business_apply_no")]
        public string QrcodeBusinessApplyNo { get; set; }
    }
}
