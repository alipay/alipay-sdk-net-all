using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// McaStoreLoanableDetail Data Structure.
    /// </summary>
    [Serializable]
    public class McaStoreLoanableDetail : AopObject
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可贷额度
        /// </summary>
        [XmlElement("loanableamt")]
        public AmountWf Loanableamt { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("sellerid")]
        public string Sellerid { get; set; }
    }
}
