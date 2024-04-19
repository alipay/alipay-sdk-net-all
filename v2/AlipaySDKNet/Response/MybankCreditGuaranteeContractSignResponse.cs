using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditGuaranteeContractSignResponse.
    /// </summary>
    public class MybankCreditGuaranteeContractSignResponse : AopResponse
    {
        /// <summary>
        /// 合约号。调用成功则返回签约合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }
    }
}
