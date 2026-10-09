using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringKbcodeCreateResponse.
    /// </summary>
    public class KoubeiCateringKbcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 口碑码创建的批次号，可以根据该批次号查询创建的具体码信息
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
