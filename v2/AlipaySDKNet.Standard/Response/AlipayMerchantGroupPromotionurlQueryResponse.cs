using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupPromotionurlQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupPromotionurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 定义群组分类，便于后台管理运营识别，可与下面设置的群名称保持一致；例：xx门店群，内部测试群
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群组推广链接
        /// </summary>
        [XmlElement("promotion_url")]
        public string PromotionUrl { get; set; }
    }
}
