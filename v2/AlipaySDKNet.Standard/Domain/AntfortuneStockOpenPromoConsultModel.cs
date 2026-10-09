using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockOpenPromoConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockOpenPromoConsultModel : AopObject
    {
        /// <summary>
        /// 指定金额发奖时必填，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 是否跨活动查询已领奖品（跨活动指非当前活动CP，使用券模板进行查询）
        /// </summary>
        [XmlElement("check_available_camp")]
        public bool CheckAvailableCamp { get; set; }

        /// <summary>
        /// 是否指定金额发奖
        /// </summary>
        [XmlElement("fix_price_send")]
        public bool FixPriceSend { get; set; }

        /// <summary>
        /// 前端控制的推荐参数
        /// </summary>
        [XmlElement("front_ctl_rec_context")]
        public string FrontCtlRecContext { get; set; }

        /// <summary>
        /// 证券营销活动id
        /// </summary>
        [XmlElement("interest_id")]
        public string InterestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 指定奖品发奖时传入
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
