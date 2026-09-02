using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniqueBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UniqueBizInfo : AopObject
    {
        /// <summary>
        /// 子业务单号对应的子使用人手机号
        /// </summary>
        [XmlElement("sub_phone_no")]
        public string SubPhoneNo { get; set; }

        /// <summary>
        /// 子业务单号
        /// </summary>
        [XmlElement("sub_unique_biz_no")]
        public string SubUniqueBizNo { get; set; }
    }
}
