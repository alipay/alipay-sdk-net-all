using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimesTypeSyncData Data Structure.
    /// </summary>
    [Serializable]
    public class TimesTypeSyncData : AopObject
    {
        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称。
        /// </summary>
        [XmlElement("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 用户和商户发生交易的交易单金额，单位元。
        /// </summary>
        [XmlElement("task_amount")]
        public string TaskAmount { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 当为次数型任务时必须传。
        /// </summary>
        [XmlElement("task_times")]
        public long TaskTimes { get; set; }
    }
}
