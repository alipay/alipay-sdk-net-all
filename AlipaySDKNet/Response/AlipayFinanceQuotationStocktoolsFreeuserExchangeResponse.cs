using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationStocktoolsFreeuserExchangeResponse.
    /// </summary>
    public class AlipayFinanceQuotationStocktoolsFreeuserExchangeResponse : AopResponse
    {
        /// <summary>
        /// 领取成功/失败，此处为false时，或者接口本身报错时，均意味着失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
