using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCstrainingOrgstructureCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCstrainingOrgstructureCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 更新数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
