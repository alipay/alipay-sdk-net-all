using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthKeywordIdentifyResponse.
    /// </summary>
    public class AlipayFinancialnetAuthKeywordIdentifyResponse : AopResponse
    {
        /// <summary>
        /// T代表下属的账号都是泛金融账号 F代表下属的账号不是泛金融账号 E代表下属的账号机构类型不一致有差异 N代表下属账号类型未知
        /// </summary>
        [XmlElement("is_financial_account")]
        public string IsFinancialAccount { get; set; }

        /// <summary>
        /// T代表是泛金融机构，F代表不是泛金融机构
        /// </summary>
        [XmlElement("is_financial_inst")]
        public string IsFinancialInst { get; set; }
    }
}
