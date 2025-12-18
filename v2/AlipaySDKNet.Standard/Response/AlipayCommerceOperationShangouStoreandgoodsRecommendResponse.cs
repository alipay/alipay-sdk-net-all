using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationShangouStoreandgoodsRecommendResponse.
    /// </summary>
    public class AlipayCommerceOperationShangouStoreandgoodsRecommendResponse : AopResponse
    {
        /// <summary>
        /// 未绑定账号跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 搜推结果
        /// </summary>
        [XmlElement("result_data")]
        public string ResultData { get; set; }
    }
}
