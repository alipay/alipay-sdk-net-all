using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityLimitationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityLimitationDTO : AopObject
    {
        /// <summary>
        /// 限制份数，与限制类型对应的数量，必须是数字格式，且与限制类型的位置要对应。 多个用英文逗号分隔
        /// </summary>
        [XmlElement("limit_num")]
        public string LimitNum { get; set; }

        /// <summary>
        /// 限制类型，每天、每人、总量。 枚举值:oneday,oneperson,totalamount 多个限制类型，用英文逗号分隔
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 是否限购：Y/N 枚举值:Y/N
        /// </summary>
        [XmlElement("limited")]
        public string Limited { get; set; }
    }
}
