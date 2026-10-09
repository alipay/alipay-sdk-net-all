using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPresettleelementEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodPresettleelementEffectModel : AopObject
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("enable_time")]
        public string EnableTime { get; set; }

        /// <summary>
        /// 幂等号列表
        /// </summary>
        [XmlArray("idempotent_no_list")]
        [XmlArrayItem("string")]
        public List<string> IdempotentNoList { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
