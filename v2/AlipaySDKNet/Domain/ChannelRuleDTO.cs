using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelRuleDTO : AopObject
    {
        /// <summary>
        /// 营销类型列表+不唯一+获取渠道详情+从数据库获取
        /// </summary>
        [XmlElement("marketing_types")]
        public string MarketingTypes { get; set; }
    }
}
