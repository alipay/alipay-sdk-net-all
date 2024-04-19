using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdConversionUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdConversionUploadModel : AopObject
    {
        /// <summary>
        /// 代理商访问灯火平台的token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 转化数据列表, 最多1000条
        /// </summary>
        [XmlArray("conversion_data_list")]
        [XmlArrayItem("conversion_data")]
        public List<ConversionData> ConversionDataList { get; set; }
    }
}
