using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPrincipalConsultModel : AopObject
    {
        /// <summary>
        /// 商家支付宝PID，根据该ID获取签约地址
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }
    }
}
