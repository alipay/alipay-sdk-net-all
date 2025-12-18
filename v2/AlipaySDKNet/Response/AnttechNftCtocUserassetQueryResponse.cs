using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocUserassetQueryResponse.
    /// </summary>
    public class AnttechNftCtocUserassetQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询分区
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("user_owned_assets")]
        [XmlArrayItem("user_owned_asset")]
        public List<UserOwnedAsset> UserOwnedAssets { get; set; }
    }
}
