using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCookQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCookQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜谱list
        /// </summary>
        [XmlArray("kb_cook_list")]
        [XmlArrayItem("kbdish_cook_info")]
        public List<KbdishCookInfo> KbCookList { get; set; }
    }
}
