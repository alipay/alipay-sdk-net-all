using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCustomerQueryResponse.
    /// </summary>
    public class AlipayTradeCustomerQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("corporation_info")]
        public CorporationInfo CorporationInfo { get; set; }

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
        /// 商户维度全局幂等键
        /// </summary>
        [XmlElement("merchant_request_no")]
        public string MerchantRequestNo { get; set; }

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

        /// <summary>
        /// 用户类型，PRIVATE-个人用户；CORPORATION-企业用户
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
