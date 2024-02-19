using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdCreativeQueryModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [XmlElement("creative_outer_id")]
        public string CreativeOuterId { get; set; }

        /// <summary>
        /// 交易ID（灯火平台生成，请联系灯火运营获取）
        /// </summary>
        [XmlElement("deal_id")]
        public string DealId { get; set; }

        /// <summary>
        /// 交易类型，如果是ReachMax公司，固定传字符串"ReachMax"
        /// </summary>
        [XmlElement("deal_type")]
        public string DealType { get; set; }
    }
}
