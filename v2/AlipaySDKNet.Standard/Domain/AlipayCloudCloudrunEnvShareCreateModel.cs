using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunEnvShareCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunEnvShareCreateModel : AopObject
    {
        /// <summary>
        /// 源应用id（公共请求参数中app_id）的环境资源id。
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 源app_id（公共请求参数中的app_id）的环境资源所属产品code。如：云托管 cloudrun_product; 云开发cloudbase_product
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 目标应用id，新增资源复用关联应用的id，进行复用源app_id（公共请求参数中app_id）资源环境的app_id。
        /// </summary>
        [XmlElement("share_app_id")]
        public string ShareAppId { get; set; }
    }
}
