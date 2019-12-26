using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosDishbatchDeleteResponse.
    /// </summary>
    public class KoubeiCateringPosDishbatchDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除成功的ID
        /// </summary>
        [XmlArray("dish_ids")]
        [XmlArrayItem("string")]
        public List<string> DishIds { get; set; }
    }
}
