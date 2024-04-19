using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusAvailableQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusAvailableQueryResponse : AopResponse
    {
        /// <summary>
        /// 城市可用时间和用户geohash可用额度
        /// </summary>
        [XmlElement("result")]
        public CloudbusAvaliableItem Result { get; set; }
    }
}
