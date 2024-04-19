using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAuthorizationRedicturlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAuthorizationRedicturlGetModel : AopObject
    {
        /// <summary>
        /// 授权令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费用类型(制度新增/编辑时所用)
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 费用类型列表
        /// </summary>
        [XmlArray("expense_types")]
        [XmlArrayItem("string")]
        public List<string> ExpenseTypes { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 页面菜单key
        /// </summary>
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }

        /// <summary>
        /// [{"fieldValue":"CAR","filedName":"expenseType"}]
        /// </summary>
        [XmlArray("open_attribute_list")]
        [XmlArrayItem("open_attribute_d_t_o")]
        public List<OpenAttributeDTO> OpenAttributeList { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
