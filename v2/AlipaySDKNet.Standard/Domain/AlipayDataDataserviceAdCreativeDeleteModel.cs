using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdCreativeDeleteModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 要删除创意对应的外部资源ID集合，单批次最多支持20个广告，该ID由用户自己维护和对应
        /// </summary>
        [XmlArray("creative_outer_id_list")]
        [XmlArrayItem("string")]
        public List<string> CreativeOuterIdList { get; set; }

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
    }
}
