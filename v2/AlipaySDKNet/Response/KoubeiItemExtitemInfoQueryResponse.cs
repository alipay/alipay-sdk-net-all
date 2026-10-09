using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部商品信息
        /// </summary>
        [XmlElement("kb_ext_item_info")]
        public KbExtItemInfo KbExtItemInfo { get; set; }
    }
}
