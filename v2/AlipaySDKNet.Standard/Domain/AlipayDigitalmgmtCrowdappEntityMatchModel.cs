using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtCrowdappEntityMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtCrowdappEntityMatchModel : AopObject
    {
        /// <summary>
        /// 是否判断operator是否具有crowdAppIds对应的圈选应用的权限 默认 true，即进行上述权限判断，当 operator 不可访问对应圈选应用时认为实体和圈选应用无关系 false 时，不进行圈选应用权限判断，即无论 operator 是否具有管理员权限，都认为可访问
        /// </summary>
        [XmlElement("check_crowd_app_permission")]
        public bool CheckCrowdAppPermission { get; set; }

        /// <summary>
        /// 是否判断operator是否具有crowdAppIds对应的圈选应用的权限 默认 true，即进行上述权限判断，当 operator 不可访问对应圈选应用时认为实体和圈选应用无关系 false 时，不进行圈选应用权限判断，即无论 operator 是否具有管理员权限，都认为可访问
        /// </summary>
        [XmlElement("check_row_permission")]
        public bool CheckRowPermission { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("crowd_app_ids")]
        [XmlArrayItem("string")]
        public List<string> CrowdAppIds { get; set; }

        /// <summary>
        /// 待判断与人群关系的实体ID 如为员工实体，则为员工工号，不足6 位需要补 0 如为其他实体，请先和透镜平台协调
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 工号需要补0，例如012345； 应用请传递英文名
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
