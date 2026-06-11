using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateReverseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateReverseInfo : AopObject
    {
        /// <summary>
        /// 用户凭证ID。 凭证ID为空时默认撤销use_order_no下所有数据， 凭证ID传入会校验use_order_no是否包含certificate_id核销数据
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 撤销核销次序号
        /// </summary>
        [XmlArray("serial_no_list")]
        [XmlArrayItem("string")]
        public List<string> SerialNoList { get; set; }

        /// <summary>
        /// 该值不为空时，certificate_id不能为空  次卡撤销核销的次数，只有次卡该值生效。指定次序号核销核销时，该值必须与次序号数量一致。
        /// </summary>
        [XmlElement("times_card_cancel_count")]
        public long TimesCardCancelCount { get; set; }

        /// <summary>
        /// 核销操作单号
        /// </summary>
        [XmlElement("use_order_no")]
        public string UseOrderNo { get; set; }
    }
}
