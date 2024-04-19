using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanInsightcityQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanInsightcityQueryResponse : AopResponse
    {
        /// <summary>
        /// 画像值中去除未知和其他后的总量占当前画像总量的比例
        /// </summary>
        [XmlElement("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 省级数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("portrait_province_value")]
        public List<PortraitProvinceValue> DataList { get; set; }

        /// <summary>
        /// 常住省市画像描述，固定返回“用户省市分布预测”
        /// </summary>
        [XmlElement("portrait_desc")]
        public string PortraitDesc { get; set; }

        /// <summary>
        /// 常住城市画像类型，固定值PROVINCE_CITY_DITU
        /// </summary>
        [XmlElement("portrait_key")]
        public string PortraitKey { get; set; }

        /// <summary>
        /// 常住城市的画像名称，固定返回“预测常住城市”，和B站画像名称相同
        /// </summary>
        [XmlElement("portrait_name")]
        public string PortraitName { get; set; }

        /// <summary>
        /// 数据产出的日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
