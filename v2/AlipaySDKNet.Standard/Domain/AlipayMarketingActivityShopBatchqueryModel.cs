using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityShopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityShopBatchqueryModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 商户PID,默认为当前接口调用商户。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 分页查询页码。  限制:  必须为大于0的整数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 版本号  枚举值: 2.0.0
        /// </summary>
        [XmlElement("product_version")]
        public string ProductVersion { get; set; }
    }
}
