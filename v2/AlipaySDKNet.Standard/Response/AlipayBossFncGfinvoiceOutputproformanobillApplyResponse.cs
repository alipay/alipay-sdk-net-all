using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfinvoiceOutputproformanobillApplyResponse.
    /// </summary>
    public class AlipayBossFncGfinvoiceOutputproformanobillApplyResponse : AopResponse
    {
        /// <summary>
        /// 无账单申请成功返回的申请orderId
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
