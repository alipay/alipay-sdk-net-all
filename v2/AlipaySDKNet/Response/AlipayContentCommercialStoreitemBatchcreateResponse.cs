using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentCommercialStoreitemBatchcreateResponse.
    /// </summary>
    public class AlipayContentCommercialStoreitemBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 带货车商品相关信息结果
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("live_store_item_info_d_t_o")]
        public List<LiveStoreItemInfoDTO> ItemInfoList { get; set; }
    }
}
