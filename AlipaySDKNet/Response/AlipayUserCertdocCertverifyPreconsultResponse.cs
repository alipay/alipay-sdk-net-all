using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertdocCertverifyPreconsultResponse.
    /// </summary>
    public class AlipayUserCertdocCertverifyPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 申请验证ID。有效期为 2 小时，过期后在校验接口使用会报错 "校验信息已过期"。
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
