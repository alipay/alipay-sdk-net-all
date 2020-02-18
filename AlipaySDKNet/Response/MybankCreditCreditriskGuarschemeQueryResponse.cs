using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditCreditriskGuarschemeQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskGuarschemeQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可用担保额度
        /// </summary>
        [XmlElement("available_amt")]
        public string AvailableAmt { get; set; }
    }
}
