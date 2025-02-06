using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankDailybillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankDailybillCreateModel : AopObject
    {
        /// <summary>
        /// 活动来源 【注意事项】bill_source表示活动来源，供银行查询服务商或小二为其配置活动的账单，服务商可忽略不传
        /// </summary>
        [XmlElement("bill_source")]
        public string BillSource { get; set; }

        /// <summary>
        /// 申请查询的账单类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
