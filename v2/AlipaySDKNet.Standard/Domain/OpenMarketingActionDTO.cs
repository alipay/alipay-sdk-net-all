using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenMarketingActionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenMarketingActionDTO : AopObject
    {
        /// <summary>
        /// 行动点ID
        /// </summary>
        [XmlElement("action_id")]
        public string ActionId { get; set; }

        /// <summary>
        /// 行动点名称
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 行动点类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }
    }
}
