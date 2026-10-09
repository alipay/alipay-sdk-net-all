using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentEventSendModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 灵工保领域事件
        /// </summary>
        [XmlElement("domain_event")]
        public InsLGBDomainEvent DomainEvent { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 投保场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
