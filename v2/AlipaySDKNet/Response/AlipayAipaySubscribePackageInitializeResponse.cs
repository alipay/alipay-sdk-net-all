using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipaySubscribePackageInitializeResponse.
    /// </summary>
    public class AlipayAipaySubscribePackageInitializeResponse : AopResponse
    {
        /// <summary>
        /// 订阅初始化返回数据
        /// </summary>
        [XmlElement("data")]
        public SubscribeInitiateApiResponse Data { get; set; }
    }
}
