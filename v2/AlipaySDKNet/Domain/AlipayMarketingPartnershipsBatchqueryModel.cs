using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingPartnershipsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingPartnershipsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 授权给合作方的营销资源。
        /// </summary>
        [XmlElement("authorized_data")]
        public MarketingAuthorizedData AuthorizedData { get; set; }

        /// <summary>
        /// 分页查询页码。  限制:  1.必须为大于0的整数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 合作方相关信息
        /// </summary>
        [XmlElement("partner")]
        public MarketingPartner Partner { get; set; }

        /// <summary>
        /// 合作状态，枚举值：  ESTABLISHED：已建立  TERMINATED：已终止
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
