using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountAssetlibviewRealtimebalanceQueryResponse.
    /// </summary>
    public class AlipayUserAccountAssetlibviewRealtimebalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金账户实时可用余额，人民币，单位元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }
    }
}
