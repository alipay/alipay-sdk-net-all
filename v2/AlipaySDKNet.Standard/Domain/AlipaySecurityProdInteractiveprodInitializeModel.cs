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
        /// 业务id，标识唯一一次调用，全局唯一，可以是uuid
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务参数，JSON格式
        /// </summary>
        [XmlElement("biz_request_params")]
        public string BizRequestParams { get; set; }

        /// <summary>
        /// 是否走策略推荐，若为true，则由策略动态决策，默认为false
        /// </summary>
        [XmlElement("need_consult")]
        public bool NeedConsult { get; set; }

        /// <summary>
        /// 用户（user_id）在应用（appId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 场景id，格式为systemName_bizProduct_bizProdNode_accessChannel，标识系统-产品-产品节点-接入渠道
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 租户id，用以区分各商户，例如公司名称英文缩写
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 用户id，用以标识单个用户，可以为用户支付宝账号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
