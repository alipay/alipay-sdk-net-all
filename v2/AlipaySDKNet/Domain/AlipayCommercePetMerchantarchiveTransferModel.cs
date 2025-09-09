using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePetMerchantarchiveTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePetMerchantarchiveTransferModel : AopObject
    {
        /// <summary>
        /// 支付宝宠物档案Id，与external_pet_id二选一
        /// </summary>
        [XmlElement("archive_id")]
        public string ArchiveId { get; set; }

        /// <summary>
        /// 商户宠物Id
        /// </summary>
        [XmlElement("external_pet_id")]
        public string ExternalPetId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务请求流水，用于幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
