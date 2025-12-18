using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandAppInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class BrandAppInfoOpenApi : AopObject
    {
        /// <summary>
        /// 应用appid，可以在open.alipay.com上查询
        /// </summary>
        [XmlElement("app_id_b")]
        public string AppIdB { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用类型 TINYAPP：小程序 LIFEAPP：生活号
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }
    }
}
