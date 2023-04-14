using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeBillDownloadurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeBillDownloadurlQueryModel : AopObject
    {
        /// <summary>
        /// 账单数据的产生时间
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 对应账单类型，如业务帐
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 账单的生成类型，如日账单/周账单/月账单
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 查询文件的格式
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
