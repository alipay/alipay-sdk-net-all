using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdMaterialQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdMaterialQueryModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 交易ID（灯火平台生成，请联系灯火运营获取）
        /// </summary>
        [XmlElement("deal_id")]
        public string DealId { get; set; }

        /// <summary>
        /// 交易相关字段，新机构接入时，灯火平台会生成特定的值给到接入的机构，请联系灯火运营获取
        /// </summary>
        [XmlElement("deal_type")]
        public string DealType { get; set; }

        /// <summary>
        /// 上传图片/视频物料对应的外部id，需要保证唯一
        /// </summary>
        [XmlElement("material_outer_id")]
        public string MaterialOuterId { get; set; }
    }
}
