using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyRarenameDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyRarenameDetectModel : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 主体id，打日志用，方便排查问题时定位日志。可传业务id、随机生成的uuid等。
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用于标识这笔请求的业务场景，业务可以根据实际场景自己定义取值，比如支付宝认证"alipay_certify"。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
