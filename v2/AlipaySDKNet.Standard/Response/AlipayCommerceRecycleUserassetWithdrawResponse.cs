using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleUserassetWithdrawResponse.
    /// </summary>
    public class AlipayCommerceRecycleUserassetWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 流水id，保证是唯一的
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
