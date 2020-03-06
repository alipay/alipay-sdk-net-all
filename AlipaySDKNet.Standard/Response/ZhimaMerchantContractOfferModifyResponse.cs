using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractOfferModifyResponse.
    /// </summary>
    public class ZhimaMerchantContractOfferModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务操作结果，成功或失败
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
