using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeMaterialSyncResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativeMaterialSyncResponse : AopResponse
    {
        /// <summary>
        /// 如果有创意组id 传进来的，就直接返回，如果是新建的，返回的是新建的创意组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
