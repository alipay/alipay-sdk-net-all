using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialHealtharchivesSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialHealtharchivesSyncModel : AopObject
    {
        /// <summary>
        /// 用户年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 记录商家同步的健康档案类型
        /// </summary>
        [XmlElement("archives_type")]
        public string ArchivesType { get; set; }

        /// <summary>
        /// 用户user_id，做了open_id映射
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 健康档案信息
        /// </summary>
        [XmlElement("dental_inquiry_archives_info")]
        public DentalInquiryArchivesInfo DentalInquiryArchivesInfo { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 记录商户健康档案ID，用于幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
