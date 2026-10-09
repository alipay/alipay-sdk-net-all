using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcfBankAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VcfBankAccountInfo : AopObject
    {
        /// <summary>
        /// 账户开户人名字
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 两位国家代码
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 收款方主体
        /// </summary>
        [XmlElement("recon_inst")]
        public string ReconInst { get; set; }

        /// <summary>
        /// swiftCode
        /// </summary>
        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }
    }
}
