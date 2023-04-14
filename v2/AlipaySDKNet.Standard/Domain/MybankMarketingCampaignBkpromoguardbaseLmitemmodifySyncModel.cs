using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingCampaignBkpromoguardbaseLmitemmodifySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingCampaignBkpromoguardbaseLmitemmodifySyncModel : AopObject
    {
        /// <summary>
        /// biz_id + 非唯一 + LinkedMall商品修改同步场景 + 找接口提供方确认
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// [{"canSell":true,"extJson":"{}","gmtModified":1670815972000,"itemId":626115945162,"lmItemId":"10023281-626115945162","skuList":[{"canSell":true,"points":0,"pointsAmount":0,"priceCent":60000,"skuId":4949323750970}]}]
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("lm_modify_item_list")]
        public List<LmModifyItemList> ItemList { get; set; }

        /// <summary>
        /// request_id + 唯一 + LinkedMall商品修改同步场景 + 调用方自行传递
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
