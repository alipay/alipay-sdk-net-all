using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusSchoolAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusSchoolAddModel : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 入驻学校名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 支付宝收款账号
        /// </summary>
        [XmlElement("inst_pid")]
        public string InstPid { get; set; }

        /// <summary>
        /// 社会信用编码或教育部标识码
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 办学阶段。枚举值如下：0:幼儿园 1:小学 2:初中 3:高中 4:大学 5:中职中专 6:培训机构 7:高职高专 8:成人教育、函授等 注意：如果学校兼有多种属性，可以连写用英文逗号拆分，2,3：代表兼有初中部高中部；
        /// </summary>
        [XmlElement("learning_stage")]
        public string LearningStage { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 省份code
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 学校性质.枚举值如下： 1：公立 2：民办
        /// </summary>
        [XmlElement("school_property")]
        public string SchoolProperty { get; set; }

        /// <summary>
        /// 是否测试数据，枚举值：1 是 ，0 否
        /// </summary>
        [XmlElement("test_mode")]
        public long TestMode { get; set; }
    }
}
