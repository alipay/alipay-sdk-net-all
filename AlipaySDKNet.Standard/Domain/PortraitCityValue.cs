using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitCityValue Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitCityValue : AopObject
    {
        /// <summary>
        /// 城市地区编码，唯一，遵循国标
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 资产或者人群画像中当前城市对应的用户数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 国内城市名称，唯一，如果城市没有数据则不返回
        /// </summary>
        [XmlElement("portrait_value")]
        public string PortraitValue { get; set; }
    }
}
