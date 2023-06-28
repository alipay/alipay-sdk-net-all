using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GeneralWithholdInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GeneralWithholdInfoDTO : AopObject
    {
        /// <summary>
        /// 代扣签约串
        /// </summary>
        [XmlElement("agreement_pay_sign")]
        public string AgreementPaySign { get; set; }
    }
}
