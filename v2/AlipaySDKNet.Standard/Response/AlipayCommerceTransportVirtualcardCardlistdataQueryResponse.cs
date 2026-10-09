using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVirtualcardCardlistdataQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVirtualcardCardlistdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 子场景卡列表
        /// </summary>
        [XmlArray("identification_card_list")]
        [XmlArrayItem("sub_scene_card_model")]
        public List<SubSceneCardModel> IdentificationCardList { get; set; }
    }
}
