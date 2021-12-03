using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentPublishResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardcontentPublishResponse : AopResponse
    {
        /// <summary>
        /// 内容发布后生成的ID，请建议业务方务必保存到本地（关联查询内容详情、删除内容等其他开放接口）
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
