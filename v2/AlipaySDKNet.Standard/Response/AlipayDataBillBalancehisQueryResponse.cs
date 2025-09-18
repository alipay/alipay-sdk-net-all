using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillBalancehisQueryResponse.
    /// </summary>
    public class AlipayDataBillBalancehisQueryResponse : AopResponse
    {
        /// <summary>
        /// 期初余额，单位（元）
        /// </summary>
        [XmlElement("beginning_balance")]
        public string BeginningBalance { get; set; }

        /// <summary>
        /// 期末余额，单位（元）
        /// </summary>
        [XmlElement("ending_balance")]
        public string EndingBalance { get; set; }
    }
}
