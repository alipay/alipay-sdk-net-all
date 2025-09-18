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
        /// 内容发布后生成的ID，请业务方保存到本地（用于关联查询内容详情、删除内容等其他开放接口）
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 用于提示发文成功后的一些提示信息，例如：内容挂载的POI位置信息不合法，请前往内容后台进行修改等
        /// </summary>
        [XmlElement("extra_msg")]
        public string ExtraMsg { get; set; }
    }
}
