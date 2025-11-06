using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceOutunsignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceOutunsignSyncModel : AopObject
    {
        /// <summary>
        /// 保司类型，如平安养老险-PINGAN_YLX
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 购买保司产品的企业ID，如：中国移动
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 开通状态，1-签约、2-解约
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
