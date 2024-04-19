using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniWidgetGoodsModifyResponse.
    /// </summary>
    public class AlipayOpenMiniWidgetGoodsModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品修改返回的提交ID，用于查询商品信息的审核状态
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }
    }
}
