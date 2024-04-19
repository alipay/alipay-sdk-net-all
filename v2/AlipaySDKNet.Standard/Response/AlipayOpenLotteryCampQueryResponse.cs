using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampQueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果，活动详情
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
