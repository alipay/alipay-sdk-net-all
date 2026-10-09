using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAgreementQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有效
        /// </summary>
        [XmlElement("active_flag")]
        public bool ActiveFlag { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部业务平台的用户ID
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }

        /// <summary>
        /// 签约产品的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约产品的产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 签约的产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("signing_time")]
        public string SigningTime { get; set; }
    }
}
