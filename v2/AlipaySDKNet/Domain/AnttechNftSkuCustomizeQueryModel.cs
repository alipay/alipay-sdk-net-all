using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuCustomizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuCustomizeQueryModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("fans_id")]
        public string FansId { get; set; }

        /// <summary>
        /// 用户ID类型
        /// </summary>
        [XmlElement("fans_id_type")]
        public string FansIdType { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 合作方交易唯一识别号
        /// </summary>
        [XmlElement("third_biz_no")]
        public string ThirdBizNo { get; set; }
    }
}
