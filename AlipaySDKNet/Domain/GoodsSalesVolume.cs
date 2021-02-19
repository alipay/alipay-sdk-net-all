using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsSalesVolume Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsSalesVolume : AopObject
    {
        /// <summary>
        /// 商品销量周期。使用枚举值 MONTH/HALF_YEAR/YEAR 分别表示月/半年/年
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 销量数值串，需要为整数
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }
    }
}
