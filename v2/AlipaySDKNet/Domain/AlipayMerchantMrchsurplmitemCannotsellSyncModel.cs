using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemCannotsellSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantMrchsurplmitemCannotsellSyncModel : AopObject
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [XmlElement("notice_time")]
        public long NoticeTime { get; set; }

        /// <summary>
        /// 通知类型 TB_ZERO_INVENTORY：淘宝库存为0 LM_ZERO_INVENTORY：lm限购库存为0
        /// </summary>
        [XmlElement("notice_type")]
        public string NoticeType { get; set; }

        /// <summary>
        /// 请求ID
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
