using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenNppdUsertbidQueryResponse.
    /// </summary>
    public class AlipayOpenNppdUsertbidQueryResponse : AopResponse
    {
        /// <summary>
        /// 淘宝ID
        /// </summary>
        [XmlElement("tb_id")]
        public string TbId { get; set; }
    }
}
