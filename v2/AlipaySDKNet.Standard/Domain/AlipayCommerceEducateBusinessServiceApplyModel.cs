using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateBusinessServiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateBusinessServiceApplyModel : AopObject
    {
        /// <summary>
        /// 如果所在学校有多个校区，传入分校区名称
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 城市国家编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县国家编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// ISV名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// ISV联系电话
        /// </summary>
        [XmlElement("isv_telephone")]
        public string IsvTelephone { get; set; }

        /// <summary>
        /// 省份国家编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校企业支付宝账户。直连模式下必填。
        /// </summary>
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学校性质 枚举值如下： 1：公立 2：民办
        /// </summary>
        [XmlElement("school_property")]
        public string SchoolProperty { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学校类型。枚举值如下：0:幼儿园 1:小学 2:初中 3:高中 4:大学 5:中职中专 6:培训机构 7:高职高专 8:成人教育、函授等 10.政务机关 注意：如果学校兼有多种属性，可以连写用英文逗号拆分，比如：2,3：代表兼有初中部高中部；
        /// </summary>
        [XmlElement("school_type")]
        public string SchoolType { get; set; }

        /// <summary>
        /// 直付通二级服务商编号。直付通模式下必填
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
