using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarUnionmemberSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarUnionmemberSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝业务卡号
        /// </summary>
        [XmlElement("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 车生活定义的车辆品牌ID，车企接入时咨询对应BD
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 会员卡等级（由商户在卡模板创建时自定义的等级）
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 车生活定义的车企ID，车企接入时咨询对应BD
        /// </summary>
        [XmlElement("manufacturer_id")]
        public string ManufacturerId { get; set; }

        /// <summary>
        /// 车生活定义的车型ID，车企接入时咨询对应BD
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 业务发生时间，即本次会员信息同步的当前时间
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 开卡时间
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型：开通/更新/关闭 联合会员
        /// </summary>
        [XmlElement("opt")]
        public string Opt { get; set; }

        /// <summary>
        /// 车生活定义的车系ID，车企接入时咨询对应BD
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 会员卡到期时间
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
