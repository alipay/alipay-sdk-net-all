using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesActivityperiodModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesActivityperiodModifyModel : AopObject
    {
        /// <summary>
        /// UA开头的主任务号
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部业务流水号，幂等处理，同一业务流水号只允许修改一次。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 待修改的子期任务列表
        /// </summary>
        [XmlArray("period_list")]
        [XmlArrayItem("n_sales_sub_activity_modify")]
        public List<NSalesSubActivityModify> PeriodList { get; set; }

        /// <summary>
        /// 本次修改任务周期的原因
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }
    }
}
