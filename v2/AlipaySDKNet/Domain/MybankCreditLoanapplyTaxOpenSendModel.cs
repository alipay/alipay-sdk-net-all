using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyTaxOpenSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyTaxOpenSendModel : AopObject
    {
        /// <summary>
        /// 此场景固定使用TAX_APPLET_AUTH_NOTICE
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [XmlElement("data_object")]
        public string DataObject { get; set; }
    }
}
