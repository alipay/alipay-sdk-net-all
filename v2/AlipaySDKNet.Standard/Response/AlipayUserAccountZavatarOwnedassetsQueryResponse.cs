using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountZavatarOwnedassetsQueryResponse.
    /// </summary>
    public class AlipayUserAccountZavatarOwnedassetsQueryResponse : AopResponse
    {
        /// <summary>
        /// 数字人服装vo
        /// </summary>
        [XmlArray("avatar_asset_suit_v_os")]
        [XmlArrayItem("avatar_asian_asset_v_o")]
        public List<AvatarAsianAssetVO> AvatarAssetSuitVOs { get; set; }
    }
}
