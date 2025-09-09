using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelHealtharchiveauthSubmitResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelHealtharchiveauthSubmitResponse : AopResponse
    {
        /// <summary>
        /// 权限编码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
