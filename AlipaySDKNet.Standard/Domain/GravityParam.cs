using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GravityParam Data Structure.
    /// </summary>
    [Serializable]
    public class GravityParam : AopObject
    {
        /// <summary>
        /// 属性名：content+是否唯一：无需唯一+场景：多方安全风控服务参数值+枚举：无枚举值+如何获取：调用方根据不同风控产品所需参数对其加密后传入（是否加密根据数安、隐私审批结果决定，由多方安全风控平台提供）+特殊说明：如需加密，密文加密方式为AES(SHA256(data))，AES秘钥为随机生成的128位会话秘钥
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 参数名：property+是否唯一：无需唯一+应用场景：多方安全风控咨询服务参数属性代码+枚举：无枚举+如何获取：多方安全风控平台分发+特殊说明：根据数安、隐私要求，用代码代表具体属性名称，譬如00-1616062045代表手机号
        /// </summary>
        [XmlElement("property")]
        public string Property { get; set; }
    }
}
