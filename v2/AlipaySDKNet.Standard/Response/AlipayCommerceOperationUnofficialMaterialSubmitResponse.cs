using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationUnofficialMaterialSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationUnofficialMaterialSubmitResponse : AopResponse
    {
        /// <summary>
        /// 对应所插入非官方物料数据的唯一凭证
        /// </summary>
        [XmlElement("response_id")]
        public string ResponseId { get; set; }
    }
}
