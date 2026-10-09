using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfBankcardCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfBankcardCertifyModel : AopObject
    {
        /// <summary>
        /// 银行卡号码
        /// </summary>
        [XmlElement("bank_card")]
        public string BankCard { get; set; }

        /// <summary>
        /// 18位有效身份证，字母统一大写
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
