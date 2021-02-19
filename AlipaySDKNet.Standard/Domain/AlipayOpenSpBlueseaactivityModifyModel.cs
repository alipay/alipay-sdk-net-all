using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpBlueseaactivityModifyModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 营业执照，要求证件文本信息清晰可见。 请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("business_lic")]
        public string BusinessLic { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 食品经营许可证，要求证件文本信息清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("food_business_lic")]
        public string FoodBusinessLic { get; set; }

        /// <summary>
        /// 食品流通许可证，要求证件文本信息清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("food_circulate_lic")]
        public string FoodCirculateLic { get; set; }

        /// <summary>
        /// 食品卫生许可证，要求证件文本信息清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("food_health_lic")]
        public string FoodHealthLic { get; set; }

        /// <summary>
        /// 食品生产许可证，要求证件文本信息清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("food_production_lic")]
        public string FoodProductionLic { get; set; }

        /// <summary>
        /// 餐饮服务许可证，要求证件文本信息清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("food_service_lic")]
        public string FoodServiceLic { get; set; }

        /// <summary>
        /// 门头照，要求内景照片清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("indoor_pic")]
        public string IndoorPic { get; set; }

        /// <summary>
        /// 申请单 id。通过 <a href="https://opendocs.alipay.com/apis/01ebig">alipay.open.sp.blueseaactivity.create</a>接口获取。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门头照，要求店铺外观照片清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("shop_entrance_pic")]
        public string ShopEntrancePic { get; set; }

        /// <summary>
        /// 烟草专卖零售许可证，要求证件文本信息清晰可见。请上传照片的image_id，传参明细请参见<a href="https://opendocs.alipay.com/open/01hd83">报名资质要求</a>
        /// </summary>
        [XmlElement("tobacco_lic")]
        public string TobaccoLic { get; set; }
    }
}
