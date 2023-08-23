using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourceusageMonthlyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourceusageMonthlyQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 结束月份
        /// </summary>
        [XmlElement("end_month")]
        public string EndMonth { get; set; }

        /// <summary>
        /// 计费项编码
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 起始月份
        /// </summary>
        [XmlElement("start_month")]
        public string StartMonth { get; set; }
    }
}
