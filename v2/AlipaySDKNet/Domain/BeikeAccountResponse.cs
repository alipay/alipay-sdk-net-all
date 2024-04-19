using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BeikeAccountResponse Data Structure.
    /// </summary>
    [Serializable]
    public class BeikeAccountResponse : AopObject
    {
        /// <summary>
        /// 当前操作变化值
        /// </summary>
        [XmlElement("change_amount")]
        public long ChangeAmount { get; set; }

        /// <summary>
        /// 呗壳当前用户所有的免息额度值，long类型
        /// </summary>
        [XmlElement("current_amount")]
        public long CurrentAmount { get; set; }

        /// <summary>
        /// 外部唯一单号
        /// </summary>
        [XmlElement("outer_biz_no")]
        public string OuterBizNo { get; set; }
    }
}
