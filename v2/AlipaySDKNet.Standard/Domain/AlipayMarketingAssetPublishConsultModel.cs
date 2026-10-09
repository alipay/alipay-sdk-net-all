using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingAssetPublishConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingAssetPublishConsultModel : AopObject
    {
        /// <summary>
        /// 传入业务信息
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 实体id类型，用于区分发放咨询对应的实体id，可以是类目id、券id、立减id等
        /// </summary>
        [XmlElement("entity_id_type")]
        public string EntityIdType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 包括实体id等信息
        /// </summary>
        [XmlArray("publish_consult_infos")]
        [XmlArrayItem("publish_consult_info")]
        public List<PublishConsultInfo> PublishConsultInfos { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
