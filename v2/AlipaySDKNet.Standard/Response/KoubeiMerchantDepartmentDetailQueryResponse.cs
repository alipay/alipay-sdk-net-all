using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentDetailQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 人员管理场景的部门id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 员工管理场景下的商户部门名称，根目录为商户名称，下属部门由商户自己创建，例如可以创建下属部门为“华东大区”
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 人员组织场景的部门标签码
        /// </summary>
        [XmlElement("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 当前部门的上级部门id
        /// </summary>
        [XmlElement("parent_dept_id")]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// 部门下包含的门店
        /// </summary>
        [XmlArray("shops")]
        [XmlArrayItem("simple_shop_model")]
        public List<SimpleShopModel> Shops { get; set; }

        /// <summary>
        /// 组织部门类型(5为非叶子部门，6为叶子部门)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
