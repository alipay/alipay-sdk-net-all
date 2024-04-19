using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignSelfVoucherQueryModel : AopObject
    {
        /// <summary>
        /// 场景码：默认(DEFAULT)  场景码与业务类型强相关，接入时候请务必和支付宝技术对接人确认。需要传入特定业务场景的场景码
        /// </summary>
        [XmlArray("scene_code")]
        [XmlArrayItem("string")]
        public List<string> SceneCode { get; set; }

        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
