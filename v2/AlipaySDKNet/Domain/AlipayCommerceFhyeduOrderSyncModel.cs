using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFhyeduOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFhyeduOrderSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("course_detail_list")]
        [XmlArrayItem("edu_order_course_detail")]
        public List<EduOrderCourseDetail> CourseDetailList { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 机构电话
        /// </summary>
        [XmlElement("inst_phone")]
        public string InstPhone { get; set; }

        /// <summary>
        /// 最近支付时间
        /// </summary>
        [XmlElement("last_payment_time")]
        public string LastPaymentTime { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("payment_list")]
        [XmlArrayItem("edu_order_payment_detail")]
        public List<EduOrderPaymentDetail> PaymentList { get; set; }

        /// <summary>
        /// 学员id
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }

        /// <summary>
        /// 学生名称
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }
    }
}
