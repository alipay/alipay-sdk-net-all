using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceVerifyAaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceVerifyAaQueryModel : AopObject
    {
        /// <summary>
        /// 米搜狐的
        /// </summary>
        [XmlElement("booleanaa")]
        public bool Booleanaa { get; set; }

        /// <summary>
        /// 排除最大值不拍最小 88,66
        /// </summary>
        [XmlElement("c")]
        public long C { get; set; }

        /// <summary>
        /// 分
        /// </summary>
        [XmlElement("ceisjnvikdv")]
        public string Ceisjnvikdv { get; set; }

        /// <summary>
        /// 列表类型，时间类型
        /// </summary>
        [XmlArray("datecc")]
        [XmlArrayItem("date")]
        public List<string> Datecc { get; set; }

        /// <summary>
        /// 时间类型
        /// </summary>
        [XmlArray("datesy")]
        [XmlArrayItem("date")]
        public List<string> Datesy { get; set; }

        /// <summary>
        /// 55,56都不排除这个值
        /// </summary>
        [XmlElement("dd")]
        public long Dd { get; set; }

        /// <summary>
        /// 座机号码
        /// </summary>
        [XmlElement("dddddcfnj")]
        public string Dddddcfnj { get; set; }

        /// <summary>
        /// 78,66最大最小都排除
        /// </summary>
        [XmlElement("dddvg")]
        public long Dddvg { get; set; }

        /// <summary>
        /// ['false','true列表类型的boolean
        /// </summary>
        [XmlArray("ddjhgfd")]
        [XmlArrayItem("boolean")]
        public List<bool> Ddjhgfd { get; set; }

        /// <summary>
        /// 排除最小值 78,66
        /// </summary>
        [XmlArray("de")]
        [XmlArrayItem("number")]
        public List<long> De { get; set; }

        /// <summary>
        /// t
        /// </summary>
        [XmlElement("f")]
        public string F { get; set; }

        /// <summary>
        /// 是
        /// </summary>
        [XmlElement("fuaza")]
        public CanshujiaoyanPeihuan Fuaza { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("fuza")]
        public CanshujiaoyanPeihuan Fuza { get; set; }

        /// <summary>
        /// 排除最小值 55，78
        /// </summary>
        [XmlArray("gr")]
        [XmlArrayItem("price")]
        public List<string> Gr { get; set; }

        /// <summary>
        /// 78,38 最大值最小值同时排除
        /// </summary>
        [XmlElement("hy")]
        public string Hy { get; set; }

        /// <summary>
        /// 66,99最大最小都不排除
        /// </summary>
        [XmlElement("ll")]
        public string Ll { get; set; }

        /// <summary>
        /// 66,78  排除最大值
        /// </summary>
        [XmlElement("prcides")]
        public string Prcides { get; set; }

        /// <summary>
        /// 最大值56，最小值66
        /// </summary>
        [XmlElement("stringstylea")]
        public string Stringstylea { get; set; }

        /// <summary>
        /// 最大长度78，最小长度66 最多元素99，最小元素88
        /// </summary>
        [XmlArray("stringstyleb")]
        [XmlArrayItem("string")]
        public List<string> Stringstyleb { get; set; }
    }
}
