using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopScoreResultInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ShopScoreResultInfoDTO : AopObject
    {
        /// <summary>
        /// 品类卖力值，客户请求入参获取分数类型（score_type），如获取该卖力值会返回，对应0-100分的6位小数
        /// </summary>
        [XmlElement("cat_sale_score")]
        public string CatSaleScore { get; set; }

        /// <summary>
        /// 品类笔单价指数，客户请求入参获取分数类型（score_type），如获取该品类笔单价指数会返回
        /// </summary>
        [XmlElement("cat_trd_amt_per_trd_score")]
        public string CatTrdAmtPerTrdScore { get; set; }

        /// <summary>
        /// 居住地热力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分的6位小数
        /// </summary>
        [XmlElement("home_user_score")]
        public string HomeUserScore { get; set; }

        /// <summary>
        /// 全店卖力值，客户请求入参获取分数类型（score_type），如获取该卖力值会返回，对应0-100分的6位小数
        /// </summary>
        [XmlElement("poi_sale_score")]
        public string PoiSaleScore { get; set; }

        /// <summary>
        /// 常驻地热力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分的6位小数
        /// </summary>
        [XmlElement("resident_user_score")]
        public string ResidentUserScore { get; set; }

        /// <summary>
        /// 笔单价指数，客户请求入参获取分数类型（score_type），如获取该笔单价指数会返回
        /// </summary>
        [XmlElement("trd_amt_per_trd_score")]
        public string TrdAmtPerTrdScore { get; set; }

        /// <summary>
        /// 工作地热力值，客户请求入参获取分数类型（score_type），如获取该热力值会返回，对应0-100分的6位小数
        /// </summary>
        [XmlElement("work_user_score")]
        public string WorkUserScore { get; set; }
    }
}
