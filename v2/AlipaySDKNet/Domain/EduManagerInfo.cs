using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduManagerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduManagerInfo : AopObject
    {
        /// <summary>
        /// 学工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 管理员ID
        /// </summary>
        [XmlElement("manager_id")]
        public string ManagerId { get; set; }

        /// <summary>
        /// 管理员类型
        /// </summary>
        [XmlElement("manager_type")]
        public string ManagerType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 管理的组织节点列表
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("edu_node_info")]
        public List<EduNodeInfo> NodeList { get; set; }

        /// <summary>
        /// 管理的位置列表
        /// </summary>
        [XmlArray("place_list")]
        [XmlArrayItem("edu_place_info")]
        public List<EduPlaceInfo> PlaceList { get; set; }

        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
