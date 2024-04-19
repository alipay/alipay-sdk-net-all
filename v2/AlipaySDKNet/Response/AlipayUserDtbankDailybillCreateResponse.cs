using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankDailybillCreateResponse.
    /// </summary>
    public class AlipayUserDtbankDailybillCreateResponse : AopResponse
    {
        /// <summary>
        /// 账单申请号
        /// </summary>
        [XmlElement("bill_application_id")]
        public string BillApplicationId { get; set; }
    }
}
