using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyRarenameMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyRarenameMatchModel : AopObject
    {
        /// <summary>
        /// 主体id，打日志用于方便排查问题用，可传业务id，没业务id的可传一个随机生成的uuid。
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用于标识这笔请求的业务场景，业务可以根据实际场景自己定义取值，比如支付宝认证"alipay_certify"。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 源姓名
        /// </summary>
        [XmlElement("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// 目标姓名
        /// </summary>
        [XmlElement("target_name")]
        public string TargetName { get; set; }
    }
}
