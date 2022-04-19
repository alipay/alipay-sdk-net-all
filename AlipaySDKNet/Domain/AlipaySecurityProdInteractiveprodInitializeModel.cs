using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdInteractiveprodInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdInteractiveprodInitializeModel : AopObject
    {
        /// <summary>
        /// 业务Id，全局唯一id，可以是uuid
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务参数，JSON格式
        /// </summary>
        [XmlElement("biz_request_params")]
        public string BizRequestParams { get; set; }

        /// <summary>
        /// 是否需要推荐，若为false，需在biz_request_params中传递productList
        /// </summary>
        [XmlElement("need_consult")]
        public bool NeedConsult { get; set; }

        /// <summary>
        /// 场景Id，格式为systemName_bizProduct_bizProdNode_accessChannel，标识系统-产品-产品节点-接入渠道
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
