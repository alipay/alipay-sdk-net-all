using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskGravityConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskGravityConsultModel : AopObject
    {
        /// <summary>
        /// 参数名：client_id+是否唯一：无需唯一+应用场景：已鉴权的调用方id，多方安全风控用该ID对调用方可调用的数据产品鉴权+枚举：无枚举+如何获取：多方安全风控与调用方协商+特殊说明：无
        /// </summary>
        [XmlElement("authorized_client_id")]
        public string AuthorizedClientId { get; set; }

        /// <summary>
        /// 参数名：extension+是否唯一：无需唯一+应用场景：多方安全风控标准接口普通扩展参数，用于处理可能存在的小部分标准之外定制化需求+枚举：无枚举+如何获取：多方安全风控与调用方协商+特殊说明：无
        /// </summary>
        [XmlArray("extension")]
        [XmlArrayItem("gravity_param")]
        public List<GravityParam> Extension { get; set; }

        /// <summary>
        /// 参数名：header+是否唯一：无需唯一+应用场景：多方安全风控服务标准头信息，譬如系统间调用的traceId+枚举：无枚举+如何获取：调用方系统随机生成，保证全局唯一+特殊说明：无
        /// </summary>
        [XmlElement("header")]
        public SecGravityServiceHeader Header { get; set; }

        /// <summary>
        /// 参数名：params+是否唯一：无需唯一+应用场景：多方安全风控服务数据产品所需参数+枚举：无枚举+如何获取：多方安全风控通过对应数据产品介绍文档获取+特殊说明：无
        /// </summary>
        [XmlArray("params")]
        [XmlArrayItem("gravity_param")]
        public List<GravityParam> Params { get; set; }

        /// <summary>
        /// 参数名：product_id+是否唯一：无需唯一+应用场景：用于指定调用多方安全风控某个风控产品+枚举：无枚举+如何获取：多方安全风控平台分发+特殊说明：无
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 参数名：session_token+是否唯一：无需唯一+应用场景：多方安全风控会话秘钥密文+枚举：无枚举+如何获取：多方安全风控分发公钥后通过公钥加密会话秘钥+特殊说明：无
        /// </summary>
        [XmlElement("session_token")]
        public string SessionToken { get; set; }
    }
}
