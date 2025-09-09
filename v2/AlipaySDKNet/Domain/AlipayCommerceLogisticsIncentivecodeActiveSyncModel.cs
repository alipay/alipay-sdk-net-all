using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsIncentivecodeActiveSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsIncentivecodeActiveSyncModel : AopObject
    {
        /// <summary>
        /// 码值绑定时位置的区
        /// </summary>
        [XmlElement("active_area")]
        public string ActiveArea { get; set; }

        /// <summary>
        /// 码值绑定时位置的城市
        /// </summary>
        [XmlElement("active_city")]
        public string ActiveCity { get; set; }

        /// <summary>
        /// 码值绑定主体对应的支付宝用户id
        /// </summary>
        [XmlElement("active_code_open_id")]
        public string ActiveCodeOpenId { get; set; }

        /// <summary>
        /// 码值绑定主体对应的支付宝用户id
        /// </summary>
        [XmlElement("active_code_user_id")]
        public string ActiveCodeUserId { get; set; }

        /// <summary>
        /// 码值绑定时位置的详细地址
        /// </summary>
        [XmlElement("active_detail_address")]
        public string ActiveDetailAddress { get; set; }

        /// <summary>
        /// 码值绑定时位置的纬度，单位：度
        /// </summary>
        [XmlElement("active_latitude")]
        public string ActiveLatitude { get; set; }

        /// <summary>
        /// 码值绑定时位置的经度，单位：度
        /// </summary>
        [XmlElement("active_longitude")]
        public string ActiveLongitude { get; set; }

        /// <summary>
        /// 碰一下物料铺设门店编码
        /// </summary>
        [XmlElement("active_out_shop_id")]
        public string ActiveOutShopId { get; set; }

        /// <summary>
        /// 码值绑定时位置的省份
        /// </summary>
        [XmlElement("active_province")]
        public string ActiveProvince { get; set; }

        /// <summary>
        /// 碰一下物料铺设门店名称
        /// </summary>
        [XmlElement("active_shop_name")]
        public string ActiveShopName { get; set; }

        /// <summary>
        /// 码值绑定时位置的街道
        /// </summary>
        [XmlElement("active_street")]
        public string ActiveStreet { get; set; }

        /// <summary>
        /// 用于传入的时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// EXPRESSMAN 代表快递员 STATION 代表驿站
        /// </summary>
        [XmlElement("active_type")]
        public string ActiveType { get; set; }

        /// <summary>
        /// 用于标识激励码
        /// </summary>
        [XmlElement("incentive_code")]
        public string IncentiveCode { get; set; }

        /// <summary>
        /// 商户标识（接口调用方的渠道编码，由支付宝分配）
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }
    }
}
