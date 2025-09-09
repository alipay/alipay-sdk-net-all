using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelLockerOrgSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelLockerOrgSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝组织唯一ID ,更新传入
        /// </summary>
        [XmlElement("alipay_org_id")]
        public string AlipayOrgId { get; set; }

        /// <summary>
        /// 所在区
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 区域码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 酒店品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 服务商侧酒店或学校唯一ID
        /// </summary>
        [XmlElement("isv_org_id")]
        public string IsvOrgId { get; set; }

        /// <summary>
        /// 坐标维度degrees
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 坐标经度degrees
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户入驻蚂蚁后获取的商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 数据集成服务商code
        /// </summary>
        [XmlElement("operators_code")]
        public string OperatorsCode { get; set; }

        /// <summary>
        /// 门店具体所在地址
        /// </summary>
        [XmlElement("org_address")]
        public string OrgAddress { get; set; }

        /// <summary>
        /// 集团code
        /// </summary>
        [XmlElement("org_group_code")]
        public string OrgGroupCode { get; set; }

        /// <summary>
        /// 具体门店的完整名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 所在省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 省份编码，按照省份证号码规则
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 场景类型：学校-SCHOOL，酒店-HOTEL
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 蚂蚁门店ID，如果是连锁模式，需要在蚂蚁商户下录入门店信息
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
