using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishSpecgroupSyncResponse : AopResponse
    {
        /// <summary>
        /// 12323
        /// </summary>
        [XmlElement("kbdish_spec_group_id")]
        public string KbdishSpecGroupId { get; set; }
    }
}
