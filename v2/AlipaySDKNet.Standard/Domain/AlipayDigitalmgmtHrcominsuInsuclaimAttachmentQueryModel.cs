using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimAttachmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcominsuInsuclaimAttachmentQueryModel : AopObject
    {
        /// <summary>
        /// attachment_url+不唯一+供应商获取理赔附件+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("attachment_url")]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// data_key+唯一+供应商获取理赔附件+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }
    }
}
