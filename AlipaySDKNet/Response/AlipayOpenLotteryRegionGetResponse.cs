using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionGetResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionGetResponse : AopResponse
    {
        /// <summary>
        /// 入驻商家专区信息
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
