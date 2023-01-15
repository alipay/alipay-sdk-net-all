using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitDataVO Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitDataVO : AopObject
    {
        /// <summary>
        /// 覆盖率，画像值中去除未知和其他后的总量占当前画像总量的比例
        /// </summary>
        [XmlElement("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("portrait_value")]
        public List<PortraitValue> DataList { get; set; }

        /// <summary>
        /// 画像描述，如：用户年龄段预测
        /// </summary>
        [XmlElement("portrait_desc")]
        public string PortraitDesc { get; set; }

        /// <summary>
        /// 画像key，如：AGE
        /// </summary>
        [XmlElement("portrait_key")]
        public string PortraitKey { get; set; }

        /// <summary>
        /// 画像名称，如：用户年龄段
        /// </summary>
        [XmlElement("portrait_name")]
        public string PortraitName { get; set; }

        /// <summary>
        /// 数据日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
