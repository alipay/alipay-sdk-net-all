using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunEnvShareQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunEnvShareQueryResponse : AopResponse
    {
        /// <summary>
        /// 资源复用关联应用环境，已资源复用源app_id（公共请求参数中的app_id）资源环境关联列表中的单个应用环境。其中包括关联应用id、源应用id的环境id、源应用id的环境资源所属产品code等
        /// </summary>
        [XmlElement("app_env_shares")]
        public AppEnvShare AppEnvShares { get; set; }

        /// <summary>
        /// 对返回结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
