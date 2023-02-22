using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignBkpromoguardbaseLmitemdeleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignBkpromoguardbaseLmitemdeleteSyncModel : AopObject
    {
        /// <summary>
        /// biz_id + 非唯一 + LinkedMall商品删除同步场景 + 找接口提供方确认
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// item_id_list + 非唯一 + LinkedMall商品删除同步场景 + 调用方自行传递
        /// </summary>
        [XmlElement("item_id_list")]
        public LmDeleteItemList ItemIdList { get; set; }

        /// <summary>
        /// request_id + 唯一 + LinkedMall商品删除同步场景 + 调用方自行传递
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
