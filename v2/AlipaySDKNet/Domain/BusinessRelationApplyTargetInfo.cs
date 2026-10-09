using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationApplyTargetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationApplyTargetInfo : AopObject
    {
        /// <summary>
        /// 申请的产品能力对应的目标id，当产品码为门店经营分析数据产品码时，填门店编号
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
