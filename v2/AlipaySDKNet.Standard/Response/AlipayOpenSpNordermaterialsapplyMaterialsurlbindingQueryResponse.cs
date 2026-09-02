using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsurlbindingQueryResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyMaterialsurlbindingQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("url_binding_infos")]
        [XmlArrayItem("url_binding_info")]
        public List<UrlBindingInfo> UrlBindingInfos { get; set; }
    }
}
