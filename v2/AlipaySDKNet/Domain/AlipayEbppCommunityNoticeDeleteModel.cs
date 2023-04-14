using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityNoticeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityNoticeDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝公告id
        /// </summary>
        [XmlElement("alipay_notice_id")]
        public long AlipayNoticeId { get; set; }

        /// <summary>
        /// 产品类型： OWNER_CARD 电子业主卡
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 产品子类型： HANGZHOU_OWNER_CARD 杭州房管局电子业主卡
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
