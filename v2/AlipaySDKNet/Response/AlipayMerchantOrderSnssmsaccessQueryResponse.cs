using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantOrderSnssmsaccessQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderSnssmsaccessQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户准入地址
        /// </summary>
        [XmlArray("access_scene_url_info")]
        [XmlArrayItem("access_scene_url")]
        public List<AccessSceneUrl> AccessSceneUrlInfo { get; set; }

        /// <summary>
        /// 准入标志
        /// </summary>
        [XmlElement("valid_access_flag")]
        public bool ValidAccessFlag { get; set; }
    }
}
