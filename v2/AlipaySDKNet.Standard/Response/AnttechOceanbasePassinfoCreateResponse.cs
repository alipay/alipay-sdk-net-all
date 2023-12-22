using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassinfoCreateResponse.
    /// </summary>
    public class AnttechOceanbasePassinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 登录态
        /// </summary>
        [XmlElement("authorization")]
        public string Authorization { get; set; }
    }
}
