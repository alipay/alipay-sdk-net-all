using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePagedataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodePagedataSendModel : AopObject
    {
        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 结课月份
        /// </summary>
        [XmlElement("course_end_month")]
        public string CourseEndMonth { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 开课月份
        /// </summary>
        [XmlElement("course_start_month")]
        public string CourseStartMonth { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付金额，格式为0.00
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 课程周期类型,固定写MONTH
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商户smid，间联必传
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 学员姓名
        /// </summary>
        [XmlElement("user_display_name")]
        public string UserDisplayName { get; set; }
    }
}
