using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountCloseBusinessParams Data Structure.
    /// </summary>
    [Serializable]
    public class AccountCloseBusinessParams : AopObject
    {
        /// <summary>
        /// 当前访问的记账本关联的授权协议ID，访问授权记账本时必须提供
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
