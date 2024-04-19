using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierAuthassetQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierAuthassetQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业授权资产信息列表
        /// </summary>
        [XmlArray("asset_infos")]
        [XmlArrayItem("ep_asset_info")]
        public List<EpAssetInfo> AssetInfos { get; set; }

        /// <summary>
        /// 是否授权
        /// </summary>
        [XmlElement("has_authed")]
        public bool HasAuthed { get; set; }
    }
}
