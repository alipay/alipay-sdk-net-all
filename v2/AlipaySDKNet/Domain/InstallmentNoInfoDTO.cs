using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentNoInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentNoInfoDTO : AopObject
    {
        /// <summary>
        /// 当前分期数
        /// </summary>
        [XmlElement("installment_no")]
        public string InstallmentNo { get; set; }

        /// <summary>
        /// 分期的阶段编码，与创建时的阶段付款计划里的阶段编码对应
        /// </summary>
        [XmlElement("stage_no")]
        public long StageNo { get; set; }
    }
}
