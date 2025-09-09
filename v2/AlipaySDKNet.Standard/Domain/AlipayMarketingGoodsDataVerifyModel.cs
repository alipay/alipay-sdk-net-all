using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingGoodsDataVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingGoodsDataVerifyModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商品额外信息
        /// </summary>
        [XmlElement("entity_info")]
        public string EntityInfo { get; set; }

        /// <summary>
        /// 支付宝分配的场景编码，用于识别活动场景及区域等信息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
