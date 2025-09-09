using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechAppcoreEnergysavingSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechAppcoreEnergysavingSubmitModel : AopObject
    {
        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 企业社会统一信用代码
        /// </summary>
        [XmlElement("company_uscc")]
        public string CompanyUscc { get; set; }

        /// <summary>
        /// 供热卡号
        /// </summary>
        [XmlElement("heating_card_number")]
        public string HeatingCardNumber { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 住户ID，数据是热力公司自定义的id，数据来源于热力公司
        /// </summary>
        [XmlElement("resident_id")]
        public string ResidentId { get; set; }

        /// <summary>
        /// 提交类型
        /// </summary>
        [XmlElement("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
