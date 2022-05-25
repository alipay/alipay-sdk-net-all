using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSignatoryInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSignatoryInfoQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，需要在ione平台申请
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 租户名，ione平台申请的参数。如果默认从cif查询数据，则租户默认为semantic_custcore，可以不填。其他租户则必填。
        /// </summary>
        [XmlElement("tenant_name")]
        public string TenantName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
