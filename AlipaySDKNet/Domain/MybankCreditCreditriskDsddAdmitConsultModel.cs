using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditCreditriskDsddAdmitConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditCreditriskDsddAdmitConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝SMID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
