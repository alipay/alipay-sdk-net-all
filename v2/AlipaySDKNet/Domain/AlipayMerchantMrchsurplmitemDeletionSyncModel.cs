using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemDeletionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantMrchsurplmitemDeletionSyncModel : AopObject
    {
        /// <summary>
        /// 客户业务 ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// json序列化后的字符串
        /// </summary>
        [XmlElement("item_id_list")]
        public string ItemIdList { get; set; }

        /// <summary>
        /// 请求标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 子渠道ID
        /// </summary>
        [XmlElement("sub_biz_id")]
        public string SubBizId { get; set; }
    }
}
