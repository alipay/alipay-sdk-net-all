using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstSigConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstSigConfigInfo : AopObject
    {
        /// <summary>
        /// 行业指数代码，非枚举类型
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 原始因子值，无单位，主要是描述信号强弱的绝对数据
        /// </summary>
        [XmlElement("value_factor")]
        public string ValueFactor { get; set; }

        /// <summary>
        /// 行业排名，排名取1-45个行业，后续会随着行业增加或者减少而改变这个数字
        /// </summary>
        [XmlElement("value_rank")]
        public long ValueRank { get; set; }

        /// <summary>
        /// 上车信号标识，绝对值
        /// </summary>
        [XmlElement("value_sig")]
        public string ValueSig { get; set; }
    }
}
