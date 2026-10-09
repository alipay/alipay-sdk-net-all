using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateManagerInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateManagerInfoCreateModel : AopObject
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
        /// 管理的组织节点ID列表
        /// </summary>
        [XmlArray("node_id_list")]
        [XmlArrayItem("string")]
        public List<string> NodeIdList { get; set; }

        /// <summary>
        /// 管理的位置ID列表
        /// </summary>
        [XmlArray("place_id_list")]
        [XmlArrayItem("string")]
        public List<string> PlaceIdList { get; set; }
    }
}
