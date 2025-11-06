using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceMagaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceMagaQueryModel : AopObject
    {
        /// <summary>
        /// 工单ID（预览的请求必填，正式的不用填），预发AQ机构智能体，通过工ID获取预览数据
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
