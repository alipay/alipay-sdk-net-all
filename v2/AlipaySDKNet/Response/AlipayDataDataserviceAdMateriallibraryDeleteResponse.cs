using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdMateriallibraryDeleteResponse.
    /// </summary>
    public class AlipayDataDataserviceAdMateriallibraryDeleteResponse : AopResponse
    {
        /// <summary>
        /// 成功删除的个数
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
