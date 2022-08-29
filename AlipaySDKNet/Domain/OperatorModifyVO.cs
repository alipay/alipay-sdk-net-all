using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorModifyVO Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorModifyVO : AopObject
    {
        /// <summary>
        /// 操作员联系方式，不填则不修改。会替换操作员原有全部联系方式
        /// </summary>
        [XmlArray("contacts")]
        [XmlArrayItem("operator_contact_v_o")]
        public List<OperatorContactVO> Contacts { get; set; }

        /// <summary>
        /// 操作员名称。不填则不修改
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 角色列表。如果为空，则不会进行角色变更； 如果不为空，则会替换操作员已有的全部角色；
        /// </summary>
        [XmlArray("role_codes")]
        [XmlArrayItem("string")]
        public List<string> RoleCodes { get; set; }
    }
}
