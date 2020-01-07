using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosSidedishbatchSaveResponse.
    /// </summary>
    public class KoubeiCateringPosSidedishbatchSaveResponse : AopResponse
    {
        /// <summary>
        /// 配料添加成功的菜品
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }
    }
}
