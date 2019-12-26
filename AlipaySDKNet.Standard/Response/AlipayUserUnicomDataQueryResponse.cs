using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUnicomDataQueryResponse.
    /// </summary>
    public class AlipayUserUnicomDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁宝卡流量余额，单位M
        /// </summary>
        [XmlElement("data_balance")]
        public long DataBalance { get; set; }
    }
}
