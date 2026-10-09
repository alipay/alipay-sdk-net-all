using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodWriteofforderVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodWriteofforderVerifyModel : AopObject
    {
        /// <summary>
        /// 核销请求openapi核销Order
        /// </summary>
        [XmlElement("write_off_process_order")]
        public WriteOffProcessOrderOpenApiDTO WriteOffProcessOrder { get; set; }
    }
}
