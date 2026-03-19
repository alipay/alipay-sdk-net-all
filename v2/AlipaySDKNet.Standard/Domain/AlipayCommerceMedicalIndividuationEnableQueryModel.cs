using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndividuationEnableQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndividuationEnableQueryModel : AopObject
    {
        /// <summary>
        /// 智能体预览工单ID（预览的请求必填，正式的不用填），编辑中机构智能体，通过预览工单ID获取预览数据
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 用于区分同一个app下的机构
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 用户的userId
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
