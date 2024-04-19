using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunEnvShareDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunEnvShareDeleteModel : AopObject
    {
        /// <summary>
        /// 源应用id（公共请求参数中app_id）的环境资源id。
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 源app_id（公共请求参数中的app_id）的环境资源所属产品code。如：云托管 cloudrun_product;  云开发cloudbase_product
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 目标app_id，进行删除资源复用关联应用的id，已经复用了源app_id（公共请求参数中app_id）资源环境的app_id。
        /// </summary>
        [XmlElement("share_app_id")]
        public string ShareAppId { get; set; }
    }
}
