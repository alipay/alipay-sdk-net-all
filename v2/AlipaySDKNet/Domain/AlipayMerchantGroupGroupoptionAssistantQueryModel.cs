using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupoptionAssistantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupoptionAssistantQueryModel : AopObject
    {
        /// <summary>
        /// 需要排除的小助手内容id，创建小助手时返回的数据唯一id。修改的时候，务必传入当前小助手content_id作为excluded_content_id，才能将当前小助手的群组返回，让用户可选。
        /// </summary>
        [XmlElement("excluded_content_id")]
        public string ExcludedContentId { get; set; }

        /// <summary>
        /// 小助手类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
