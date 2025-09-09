using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetinsureSignstatusQueryResponse.
    /// </summary>
    public class AlipayCommercePetinsureSignstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
