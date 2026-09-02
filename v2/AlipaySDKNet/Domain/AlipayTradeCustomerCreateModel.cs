using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCustomerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCustomerCreateModel : AopObject
    {
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
        /// 客户手机号，和客户邮箱需至少传入1个
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
