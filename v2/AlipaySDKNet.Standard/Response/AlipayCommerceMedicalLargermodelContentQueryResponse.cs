using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelContentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelContentQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡片数据列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("page_content_card_detail")]
        public List<PageContentCardDetail> List { get; set; }
    }
}
