using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFundBindCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFundBindCancelModel : AopObject
    {
        /// <summary>
        /// 需解绑的协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
