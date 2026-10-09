using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpReportDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpReportDataInfo : AopObject
    {
        /// <summary>
        /// 上传数据所属业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户上传的数据内容，支持csv链接、png、pdf格式
        /// </summary>
        [XmlElement("biz_value")]
        public string BizValue { get; set; }

        /// <summary>
        /// 上传企业相关业务数据的相关状态，例如数据是企业无风险截图，如果企业有风险，则上报为QUERY_HAVE_RISK
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 商户上传的数据类型
        /// </summary>
        [XmlElement("value_type")]
        public string ValueType { get; set; }
    }
}
