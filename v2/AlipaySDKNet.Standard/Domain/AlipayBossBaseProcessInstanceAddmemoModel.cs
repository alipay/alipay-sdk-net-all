using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceAddmemoModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceAddmemoModel : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 流程实例Id
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
