using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegePaidVoucherConfig Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegePaidVoucherConfig : AopObject
    {
        /// <summary>
        /// 消费者充值赠送的该类型有偿券的数量
        /// </summary>
        [XmlElement("send_count")]
        public long SendCount { get; set; }

        /// <summary>
        /// 有偿券模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
