using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeDesigntextQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativeDesigntextQueryResponse : AopResponse
    {
        /// <summary>
        /// 物品布局信息
        /// </summary>
        [XmlArray("item_design_text_info_list")]
        [XmlArrayItem("item_design_text_info")]
        public List<ItemDesignTextInfo> ItemDesignTextInfoList { get; set; }
    }
}
