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
        /// 1.用户未开通芝麻返回ZM_ACCOUNT_NOT_EXISTED；2.用户未授权返回ZM_AUTH_NOT_EXIST；3.商户未开通芝麻证服务场景返回MERCHANT_ILLEGAL_AUTH_LEVEL；4. 完成准入判断返回SUCCESS；5. 查询出现异常返回 SYSTEM_FAILURE。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户芝麻分是否准入
        /// </summary>
        [XmlElement("certify_result")]
        public bool CertifyResult { get; set; }
    }
}
