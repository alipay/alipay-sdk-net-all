using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreVirtualstoreCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreVirtualstoreCreateModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 好大夫医生doctorId
        /// </summary>
        [XmlElement("hdf_space_code")]
        public string HdfSpaceCode { get; set; }

        /// <summary>
        /// 团队领衔spaceId
        /// </summary>
        [XmlElement("hdf_space_leader_code")]
        public string HdfSpaceLeaderCode { get; set; }

        /// <summary>
        /// 好大夫医生用户名
        /// </summary>
        [XmlElement("hdf_space_user_name")]
        public string HdfSpaceUserName { get; set; }

        /// <summary>
        /// 好大夫主体编码
        /// </summary>
        [XmlElement("hdf_subject_code")]
        public string HdfSubjectCode { get; set; }

        /// <summary>
        /// 好大夫主体名称
        /// </summary>
        [XmlElement("hdf_subject_name")]
        public string HdfSubjectName { get; set; }

        /// <summary>
        /// 好大夫主体类型
        /// </summary>
        [XmlElement("hdf_subject_type")]
        public string HdfSubjectType { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
