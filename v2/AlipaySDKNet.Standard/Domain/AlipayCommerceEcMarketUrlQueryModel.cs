using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcMarketUrlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcMarketUrlQueryModel : AopObject
    {
        /// <summary>
        /// 行动ID
        /// </summary>
        [XmlElement("action_id")]
        public string ActionId { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 展品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 展区id
        /// </summary>
        [XmlElement("region_id")]
        public string RegionId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
