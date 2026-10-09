using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftAccountOverseaCreateResponse.
    /// </summary>
    public class AnttechNftAccountOverseaCreateResponse : AopResponse
    {
        /// <summary>
        /// 鲸探海外账户根据租户映射的开放id
        /// </summary>
        [XmlElement("oversea_id_no")]
        public string OverseaIdNo { get; set; }
    }
}
