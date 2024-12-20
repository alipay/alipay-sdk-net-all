using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpInvestInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpInvestInfo : AopObject
    {
        /// <summary>
        /// 被投资公司的核准日期
        /// </summary>
        [XmlElement("approval_date")]
        public string ApprovalDate { get; set; }

        /// <summary>
        /// 持股比例
        /// </summary>
        [XmlElement("holding_rate")]
        public string HoldingRate { get; set; }

        /// <summary>
        /// 投资数额，单位人名币万元
        /// </summary>
        [XmlElement("inv_amount")]
        public string InvAmount { get; set; }

        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        [XmlElement("legal_representative")]
        public string LegalRepresentative { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被投资公司的曾用名
        /// </summary>
        [XmlArray("old_name")]
        [XmlArrayItem("string")]
        public List<string> OldName { get; set; }

        /// <summary>
        /// 被投资公司的登记机关
        /// </summary>
        [XmlElement("registe_organ")]
        public string RegisteOrgan { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("registr_id")]
        public string RegistrId { get; set; }

        /// <summary>
        /// 被投资公司的登记状态
        /// </summary>
        [XmlElement("registration_state")]
        public string RegistrationState { get; set; }

        /// <summary>
        /// 企业注册号或统一社会信用代码，一般为18位
        /// </summary>
        [XmlElement("tyshxydm")]
        public string Tyshxydm { get; set; }
    }
}
