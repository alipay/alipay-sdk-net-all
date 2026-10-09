using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDataapiMigrationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDataapiMigrationQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业工商资料查询，数据都是公开数据，没有个人敏感信息，格式参考 https://xin-docs.antfin-inc.com/dataapi/index.html#document-company
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
