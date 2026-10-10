using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinPreconsultModel : AopObject
    {
        /// <summary>
        /// 花呗商户活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 123为1.23元，单位为分
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 判读用户是否可以参加这个活动需要关注这个开关，true=校验查海豚限次+活动是否进行，false/不传=校验活动是否进行，如果只是想打个广告的话建议false，如果真的想校验建议true打开这个开关
        /// </summary>
        [XmlElement("camp_consult")]
        public bool CampConsult { get; set; }

        /// <summary>
        /// 行业场景标识,依赖双方约定
        /// </summary>
        [XmlElement("industry_value")]
        public string IndustryValue { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商品或订单场景描述，仅用于排查与展示，不参与核心计算
        /// </summary>
        [XmlElement("order_desc")]
        public string OrderDesc { get; set; }

        /// <summary>
        /// 如果只想拿到可以返回的花呗金范围写false，想精确知道某用户本次可以反多少花呗金选true，注意如果设置所有亲密度等级用户反同样比例的的花呗金，返回的上下限是一样的
        /// </summary>
        [XmlElement("precise_by_level")]
        public bool PreciseByLevel { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
