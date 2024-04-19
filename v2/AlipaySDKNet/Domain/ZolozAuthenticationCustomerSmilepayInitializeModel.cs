using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmilepayInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerSmilepayInitializeModel : AopObject
    {
        /// <summary>
        /// 刷脸服务Id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 商户可传入刷脸服务所需的扩展参数，json格式
        /// </summary>
        [XmlElement("service_params")]
        public string ServiceParams { get; set; }

        /// <summary>
        /// { "apdidToken": "设备指纹", "appName": "应用名称", "appVersion": "应用版本", "bioMetaInfo": "生物信息如2.3.0:3,-4" }
        /// </summary>
        [XmlElement("zimmetainfo")]
        public string Zimmetainfo { get; set; }
    }
}
