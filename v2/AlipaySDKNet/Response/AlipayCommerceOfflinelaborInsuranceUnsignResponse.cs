using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceUnsignResponse.
    /// </summary>
    public class AlipayCommerceOfflinelaborInsuranceUnsignResponse : AopResponse
    {
        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
