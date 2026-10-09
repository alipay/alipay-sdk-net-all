using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppHylabeltwoQueryResponse.
    /// </summary>
    public class ZhimaOpenAppHylabeltwoQueryResponse : AopResponse
    {
        /// <summary>
        /// 行业分类概率列表
        /// </summary>
        [XmlArray("hylabel_list")]
        [XmlArrayItem("hylabel")]
        public List<Hylabel> HylabelList { get; set; }
    }
}
