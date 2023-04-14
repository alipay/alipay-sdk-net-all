using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerMtopsyncModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerMtopsyncModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝小程序id
        /// </summary>
        [XmlElement("alipay_app_id")]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 业务来源 默认值mtop即可
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// MTOP鉴权appKey
        /// </summary>
        [XmlElement("mtop_app_key")]
        public string MtopAppKey { get; set; }

        /// <summary>
        /// 用于表示调用接口的操作类型 可选值(BIND/REBIND/UNBIND)
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }
    }
}
