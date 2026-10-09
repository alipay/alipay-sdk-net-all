using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCustomerModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCustomerModifyModel : AopObject
    {
        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("corporation_info")]
        public CorporationInfo CorporationInfo { get; set; }

        /// <summary>
        /// 需要修改的客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 客户邮箱，和客户手机号需至少传入1个
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 客户手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 用户类型，PRIVATE-个人用户；CORPORATION-企业用户
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
