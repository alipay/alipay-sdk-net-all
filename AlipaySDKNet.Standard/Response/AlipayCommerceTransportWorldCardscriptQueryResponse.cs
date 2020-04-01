using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldCardscriptQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldCardscriptQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询脚本的时间
        /// </summary>
        [XmlElement("current_time")]
        public string CurrentTime { get; set; }

        /// <summary>
        /// 基础的rpc响应信息
        /// </summary>
        [XmlElement("offlinepay_base_rpc_response_info")]
        public OfflinepayBaseRPCResponseInfo OfflinepayBaseRpcResponseInfo { get; set; }

        /// <summary>
        /// 生码脚本
        /// </summary>
        [XmlElement("script_code")]
        public string ScriptCode { get; set; }

        /// <summary>
        /// 脚本签名
        /// </summary>
        [XmlElement("script_mac")]
        public string ScriptMac { get; set; }
    }
}
