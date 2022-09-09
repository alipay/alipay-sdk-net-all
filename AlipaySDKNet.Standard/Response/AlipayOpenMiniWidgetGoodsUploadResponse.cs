using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniWidgetGoodsUploadResponse.
    /// </summary>
    public class AlipayOpenMiniWidgetGoodsUploadResponse : AopResponse
    {
        /// <summary>
        /// 商品提交生成的唯一标识，用于查询商品信息的审核状态
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }
    }
}
