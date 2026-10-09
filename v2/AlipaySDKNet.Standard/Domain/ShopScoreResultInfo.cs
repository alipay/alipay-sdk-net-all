using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopScoreResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopScoreResultInfo : AopObject
    {
        /// <summary>
        /// 品类卖力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分
        /// </summary>
        [XmlElement("cat_sale_score")]
        public long CatSaleScore { get; set; }

        /// <summary>
        /// 居住地热力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分
        /// </summary>
        [XmlElement("home_user_score")]
        public long HomeUserScore { get; set; }

        /// <summary>
        /// 全店卖力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分
        /// </summary>
        [XmlElement("poi_sale_score")]
        public long PoiSaleScore { get; set; }

        /// <summary>
        /// 常驻地热力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分
        /// </summary>
        [XmlElement("resident_user_score")]
        public long ResidentUserScore { get; set; }

        /// <summary>
        /// 工作地热力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分
        /// </summary>
        [XmlElement("work_user_score")]
        public long WorkUserScore { get; set; }
    }
}
