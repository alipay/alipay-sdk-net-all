using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAntestApplistQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestApplistQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("eco_app_info")]
        public List<EcoAppInfo> Data { get; set; }
    }
}
