using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobPayslipInitializeResponse.
    /// </summary>
    public class AlipayEbppIndustryJobPayslipInitializeResponse : AopResponse
    {
        /// <summary>
        /// 支付宝分享口令
        /// </summary>
        [XmlElement("alipay_token")]
        public string AlipayToken { get; set; }

        /// <summary>
        /// 开通收款账号授权地址；回调地址，参数为callback；url完整示例：alipays://platformapi/startapp?appId=2021004166681275&page=pages%2Fauthorize%2Findex%3Fcallback%3D$alipays%3A%2F%2F%20platformapi%2Fstartapp%3FappId%3D2021004166681275%26userName%3D%E5%BC%A0xxx%26token%3D21I21k31lb1023435vq243se34&startMultApp=YES&appClearTop=false
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
