using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneSellerDataQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
