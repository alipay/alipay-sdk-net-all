using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillFreezebalanceQueryResponse.
    /// </summary>
    public class AlipayDataBillFreezebalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 冻结金额
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }
    }
}
