using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainArSignResponse.
    /// </summary>
    public class MybankCreditSupplychainArSignResponse : AopResponse
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }
    }
}
