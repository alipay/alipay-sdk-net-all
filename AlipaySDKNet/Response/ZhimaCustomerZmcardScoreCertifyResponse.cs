using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerZmcardScoreCertifyResponse.
    /// </summary>
    public class ZhimaCustomerZmcardScoreCertifyResponse : AopResponse
    {
        /// <summary>
        /// 1.用户未开通芝麻返回ZM_ACCOUNT_NOT_EXISTED；2.用户未授权时会返回ZM_AUTH_NOT_EXIST；3.商户未开通芝麻证服务场景MERCHANT_ILLEGAL_AUTH_LEVEL；4.否则返回null。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户是否满足预先配置的芝麻分阈值
        /// </summary>
        [XmlElement("certify_result")]
        public bool CertifyResult { get; set; }
    }
}
