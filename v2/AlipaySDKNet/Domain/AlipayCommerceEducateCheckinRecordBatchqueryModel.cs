using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCheckinRecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 签到结束时间
        /// </summary>
        [XmlElement("check_in_end_time")]
        public string CheckInEndTime { get; set; }

        /// <summary>
        /// 签到开始时间
        /// </summary>
        [XmlElement("check_in_start_time")]
        public string CheckInStartTime { get; set; }

        /// <summary>
        /// 签到类型，由学生签到时，匹配到的签到规则决定
        /// </summary>
        [XmlElement("check_in_type")]
        public string CheckInType { get; set; }

        /// <summary>
        /// 学号或工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组织部门节点id
        /// </summary>
        [XmlArray("node_id_list")]
        [XmlArrayItem("string")]
        public List<string> NodeIdList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
