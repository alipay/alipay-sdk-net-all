using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DormitoryConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DormitoryConfig : AopObject
    {
        /// <summary>
        /// 允许重复签到开关，不传默认为关闭重复签到
        /// </summary>
        [XmlElement("enable_multiple")]
        public string EnableMultiple { get; set; }

        /// <summary>
        /// 最大重复签到次数，非必传，重复签到开关打开时，不传默认为50。重复签到开关关闭时，传最大重复签到次数不生效
        /// </summary>
        [XmlElement("max_multiple")]
        public long MaxMultiple { get; set; }
    }
}
