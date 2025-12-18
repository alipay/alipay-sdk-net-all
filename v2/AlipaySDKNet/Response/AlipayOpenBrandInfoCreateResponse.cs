using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenBrandInfoCreateResponse.
    /// </summary>
    public class AlipayOpenBrandInfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 编辑时需要透传，需要记录下来
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_reasons")]
        [XmlArrayItem("brand_fail_response")]
        public List<BrandFailResponse> FailReasons { get; set; }
    }
}
