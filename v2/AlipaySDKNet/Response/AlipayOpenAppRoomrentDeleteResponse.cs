using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRoomrentDeleteResponse.
    /// </summary>
    public class AlipayOpenAppRoomrentDeleteResponse : AopResponse
    {
        /// <summary>
        /// 支付宝平台侧商品ID列表，最多20个。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 支付宝商家侧商品ID列表，最多20个。
        /// </summary>
        [XmlArray("out_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutItemIdList { get; set; }
    }
}
