using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditGuaranteeContractUnsignResponse.
    /// </summary>
    public class MybankCreditGuaranteeContractUnsignResponse : AopResponse
    {
        /// <summary>
        /// 合约号。调用成功则返回对应签约的合约号。
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }
    }
}
