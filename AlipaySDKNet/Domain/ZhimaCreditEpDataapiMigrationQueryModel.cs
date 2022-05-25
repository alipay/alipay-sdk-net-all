using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDataapiMigrationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDataapiMigrationQueryModel : AopObject
    {
        /// <summary>
        /// 原来dataapi http方法，get, post, put, delete
        /// </summary>
        [XmlElement("api_method")]
        public string ApiMethod { get; set; }

        /// <summary>
        /// 原来dataapi名称，比如工商资料，主要成员
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 原来DataAPI参数
        /// </summary>
        [XmlElement("api_params")]
        public string ApiParams { get; set; }
    }
}
