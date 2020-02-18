using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationCertifyResponse.
    /// </summary>
    public class ZhimaCustomerEpIdentificationCertifyResponse : AopResponse
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取，认证完成返回的biz_no和请求的一致。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
