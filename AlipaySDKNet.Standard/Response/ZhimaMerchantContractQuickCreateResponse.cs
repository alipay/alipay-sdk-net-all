using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractQuickCreateResponse.
    /// </summary>
    public class ZhimaMerchantContractQuickCreateResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 错误说明
        /// </summary>
        [XmlElement("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 发约单单号
        /// </summary>
        [XmlElement("offer_no")]
        public string OfferNo { get; set; }
    }
}
