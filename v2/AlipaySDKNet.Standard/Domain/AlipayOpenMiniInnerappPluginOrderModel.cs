using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappPluginOrderModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 订购的服务商品ID
        /// </summary>
        [XmlElement("merchandise_id")]
        public string MerchandiseId { get; set; }

        /// <summary>
        /// 一二方支持传入appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 业务幂等号，规则为商品id+appOrigin+requestId 作为幂等流水号 非必填,不传则默认生成一个8位requestId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
