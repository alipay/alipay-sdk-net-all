using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSupplierContentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSupplierContentDeleteModel : AopObject
    {
        /// <summary>
        /// 医疗内容ID，调用发布内容返回的ID
        /// </summary>
        [XmlElement("med_content_id")]
        public string MedContentId { get; set; }

        /// <summary>
        /// 归属者的ID，当类型为生活号ID时，传支付宝生活号ID，当类型为作者ID时，传好大夫医生ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 归属者的类型：PUBLISH_ID|AUTHOR_ID
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }
    }
}
