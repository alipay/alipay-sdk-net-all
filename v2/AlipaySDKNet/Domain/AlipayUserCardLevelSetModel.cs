using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCardLevelSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCardLevelSetModel : AopObject
    {
        /// <summary>
        /// 卡等级配置
        /// </summary>
        [XmlElement("card_level_config")]
        public CardLevelConfigDTO CardLevelConfig { get; set; }

        /// <summary>
        /// operate_type:卡等级配置操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// template_id：卡模版id，为alipay.user.card.template.create接口返回的模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
