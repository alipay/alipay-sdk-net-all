using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodWriteofforderVerifyResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodWriteofforderVerifyResponse : AopResponse
    {
        /// <summary>
        /// 核销处理结果返回
        /// </summary>
        [XmlElement("result_set")]
        public WriteOffProcessResponseOpenApiDTO ResultSet { get; set; }
    }
}
