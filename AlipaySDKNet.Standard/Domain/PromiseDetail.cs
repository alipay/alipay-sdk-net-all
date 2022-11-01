using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromiseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PromiseDetail : AopObject
    {
        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务到达终态的时间
        /// </summary>
        [XmlElement("final_time")]
        public string FinalTime { get; set; }

        /// <summary>
        /// 任务完成期数
        /// </summary>
        [XmlElement("finish_periods")]
        public long FinishPeriods { get; set; }

        /// <summary>
        /// 芝麻侧的商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 生活记录模板名称
        /// </summary>
        [XmlElement("promise_name")]
        public string PromiseName { get; set; }

        /// <summary>
        /// 生活记录主记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 主任务状态
        /// </summary>
        [XmlElement("record_status")]
        public string RecordStatus { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子记录状态
        /// </summary>
        [XmlElement("sub_record_status")]
        public string SubRecordStatus { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 生活记录模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 任务总期数
        /// </summary>
        [XmlElement("total_periods")]
        public long TotalPeriods { get; set; }
    }
}
