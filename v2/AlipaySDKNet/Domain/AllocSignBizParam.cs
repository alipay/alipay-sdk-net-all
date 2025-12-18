using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AllocSignBizParam Data Structure.
    /// </summary>
    [Serializable]
    public class AllocSignBizParam : AopObject
    {
        /// <summary>
        /// 是否屏蔽签约页抽佣比例设置 true -屏蔽 false -正常展示
        /// </summary>
        [XmlElement("limit_alloc_ratio_disable")]
        public bool LimitAllocRatioDisable { get; set; }
    }
}
