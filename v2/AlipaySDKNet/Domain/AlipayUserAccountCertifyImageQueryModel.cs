using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountCertifyImageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountCertifyImageQueryModel : AopObject
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlArray("picture_url")]
        [XmlArrayItem("string")]
        public List<string> PictureUrl { get; set; }
    }
}
