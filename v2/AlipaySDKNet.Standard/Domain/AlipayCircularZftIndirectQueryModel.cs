using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCircularZftIndirectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCircularZftIndirectQueryModel : AopObject
    {
        /// <summary>
        /// 签约支付宝账户
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 进件申请单中的二级商户openid
        /// </summary>
        [XmlElement("relation_openid")]
        public string RelationOpenid { get; set; }

        /// <summary>
        /// 进件申请单中的二级商户uid
        /// </summary>
        [XmlElement("relation_uid")]
        public string RelationUid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
