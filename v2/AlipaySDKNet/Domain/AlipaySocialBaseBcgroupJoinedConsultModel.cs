using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseBcgroupJoinedConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseBcgroupJoinedConsultModel : AopObject
    {
        /// <summary>
        /// 商家/分组维度的业务标识ID
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 商家open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// BC客户群租户ID，找产品/技术同学咨询业务所对应的租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public long TenantId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识，以2088开头的16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
